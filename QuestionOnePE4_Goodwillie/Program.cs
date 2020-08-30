using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOnePE4_Goodwillie
{

    // Name: Jacob Goodwillie
    // Date: 8/29/2020
    // Project Description: Asks the user for two numbers. If either 
    // of the numbers is greater than ten, they are displayed. They
    // cannot both be greater than 10 however. This will return a false
    // boolean.
    class Program
    {
        static void Main(string[] args)
        {
            // The repeatProgram variable will loop the program as long as it remains true. The user will have 
            // to enter two numbers according to the description correctly in order to break the loop.
            bool repeatProgram = true;
            while (repeatProgram)
            {
                // isTrue will be used to check if the numbers follow the program rules.
                bool isTrue = false;
                // Recieves user input and parses it into integers. A non-number input will
                // cause an error.
                Console.WriteLine("Enter a random number between 1 and 20");
                int firstNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second random number between 1 and 20");
                int secondNum = int.Parse(Console.ReadLine());
                // Compares the two numbers the user gave. If the conditions are met, the boolean
                // isTrue becomes true.
                checkNums(firstNum, secondNum);

                // When isTrue is true the user's numbers are displayed and the program ends.
                // If isTrue isn't true the program asks the user to try again. It will continue
                // to loop.
                if (isTrue)
                {
                    Console.WriteLine("Your numbers are " + firstNum + " and " + secondNum);
                    repeatProgram = false;
                }
                else if (!isTrue)
                {
                    Console.WriteLine("Try again");
                }

                // I made my own function just to organize my code. Takes two integers as parameters
                // and compares them. The logic checks to see if either number is greater than the other, while being larger than 10,
                // and isTrue becomes true. It ignores the wrong conditions and isTrue remains false. 
                void checkNums(int x, int y)
                {
                    int xNum = x;
                    int yNum = y;

                    if (xNum > 10 && yNum < 10 || xNum < 10 && yNum > 10)
                    {
                        isTrue = true;
                    }
                }
            }
        }
    }
}
