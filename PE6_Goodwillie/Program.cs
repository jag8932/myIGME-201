using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PE6_Goodwillie
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessesLeft = 8;
            bool loopGame = true;

            Random rand = new Random();         // Generates a random number.
            int randomNum = rand.Next(0, 101);  // Declares random number between 0 and 100.

            Console.WriteLine("Your hint is: " + randomNum);
            while (guessesLeft > 0 && loopGame)
            {
                    if (guessesLeft > 1)
                    {
                        Console.WriteLine("Guess a number between 0 and 100, you have " + guessesLeft + " guesses left.");
                        displayScene(guessesLeft);
                }
                    if (guessesLeft == 1)
                    {
                        Console.WriteLine("Guess a number between 0 and 100, you have " + guessesLeft + " guess left.");
                    }

                
                int userGuess;
                bool checkValid;      // Checks if user input is a valid integer. If not a valid number, the program won't crash.
                checkValid = int.TryParse(Console.ReadLine(), out userGuess);
                Console.WriteLine("You guessed: " + userGuess);
                    if (userGuess == randomNum)
                {
                    loopGame = false;
                }
                    guessesLeft--;
                
            }

            void displayScene(int num)
            {
                int max = num;
                for(int i = 0; i < max; i++)
                {
                    Console.Write("1");
                }
             //   Console.Write("O");
            }
        }
    }
}
