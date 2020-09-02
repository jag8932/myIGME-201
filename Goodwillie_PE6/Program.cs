using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PE6_Goodwillie
{
    /* 
     Name: Jacob Goodwillie
     Date: 9/1/2020
     Description: 
     In Asteroid Defense, the player must prevent an asteroid from 
     hitting Earth by guessing a number, randomly chosen between 0
     and 100, with a margin of error of plus or minus ten. The console
     tells the user how many guesses they have left as well as displays
     a mini scene depicting the asteroid closing in on Earth. 
     */
    class Asteroid_Defense
    {
        static void Main(string[] args)
        {
            int guessesLeft = 8;
            bool loopGame = true;

            Random rand = new Random();                                // Generates a random number.
            int randomNum = rand.Next(0, 101);                         // Declares random number between 0 and 100.
            int marginError = rand.Next(randomNum - 10, randomNum + 10); /* Picks a random number around the already generated random number.
                                                                          Intended to tip off user so they have a higher chance of winning.
                                                                          In the future, I could add a levels where the harder the level the 
                                                                          greater the margin of error. */

            Console.WriteLine("Your help is needed! An asteroid is headed toward Earth and we are" +
                " missing a coordinate of the asteroid. The asteroid is anywhere from 0 to 100 units away!" +
                " Our computer has predicted a coordinate, however that number may be innacurate. The real" +
                " number can be anywhere from 10 units less or 10 units more than it. Any wrong input and the" +
                " asteroid gets closer!");

            Console.WriteLine(" ");
            Console.WriteLine("The computer predicts: " + marginError);
            Console.WriteLine(" ");

            while (guessesLeft > 0 && loopGame)     // While the player has guesses left and loopGame is true, the game repeats until the user has won or lost.
            {
                if (guessesLeft > 1)
                {
                    Console.WriteLine("You have " + guessesLeft + " guesses left.");
                   
                }
                if (guessesLeft == 1)
                {
                    Console.WriteLine("You have " + guessesLeft + " guess left.");
                }
                displayScene(guessesLeft);
                Console.WriteLine(" ");

                int userGuess;        // Holds user input.
                bool checkValid;      // Checks if user input is a valid integer. If not a valid number, the program won't crash.
                bool loopInput = false; // Controls this temperary loop so the player does not lose guesses for entering an invalid input.

                while (!loopInput)
                {
                    checkValid = int.TryParse(Console.ReadLine(), out userGuess);   // Returns true if the user's input is a convertable string.
                    if (checkValid)
                    {
                        loopInput = true;
                        if (userGuess > randomNum)
                        {
                            Console.WriteLine("Your guess is too high, aim lower!");
                        }
                        if (userGuess < randomNum)
                        {
                            Console.WriteLine("Your guess is too low, aim higher!");
                        }
                    }
                   
                    if (userGuess == randomNum)     // Show victory screen and end game.
                    {
                        victory();
                        loopGame = false;
                    }
                }
                guessesLeft--;
            }

            if (guessesLeft < 1)
            {
                destroyEarth();
            }

            /* This function displays a text based scene using 
               the console.write function. It takes an integer, num,
               which represents the time left before asteroid inpact 
               and displays certain scenerios based on its value.*/
            void displayScene(int num)
            {
                int max = num;
                if (max > 0)
                {
                    for (int i = 0; i < max; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write("O"); // O represents Earth in this case.
                        }
                        Console.Write(" ");
                        if (i == max - 1)
                        {
                            Console.Write("O~~~~~"); // O~~~ shows asteroid with tail.
                        }
                    }
                }
            }

            // Shows the destruction of Earth in text art.
            void destroyEarth()
            {
                Console.WriteLine(" ");
                Console.WriteLine("* * *");
                Console.WriteLine("* X *");
                Console.WriteLine("* * *");
                Console.WriteLine(" ");
                Console.WriteLine("Earth has been destroyed.... Game Over");
                Console.WriteLine("The correct number was actually " + randomNum +".");
            }

            // Victory screen. Tells you how many turns it took to guess the right number. Had to start the equation at 9
            // since starting at 8 gave an inaccurate answer. For example, I would finish in 3 turns but the console told 
            // me I finished in 4 turns.                                                                         
            void victory()
            {
                Console.WriteLine(" ");
                Console.WriteLine("      **");
                Console.WriteLine("O   *   *");
                Console.WriteLine("      **");
                Console.WriteLine(" ");
                Console.WriteLine("Congradulation, you found the coordinate and our defense systems blew up the asteroid!");
                Console.WriteLine("You were able to save Earth in " + (9 - guessesLeft) + " turns.");
            }
        }
    }
}
