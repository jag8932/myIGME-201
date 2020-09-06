using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Question7_Goodwillie
{

    // Name: Jacob Goodwillie
    // Date: 9/5/2020
    // Assignment: #8 question 7
    class Program
    {
        /* This program asks the user for a word and then tells them the word backward. 
           I found that the best way to solve this was to treat the string as an array.
           The program keeps track of the word's length so it knows where to start reversing an index.
           It starts at length - 1 since all arrays begin indexed at 0. Then it counts backwards and adds
           each letter to an empty string. At the end of the loop, the empty string is now filled with the 
           letters of the word in reverse order.
         */
        static void Main(string[] args)
        {
            // Prompts question and collects the user input. String reverseInput set to null as it won't have value until the
            // loop adds characters to it.
            Console.WriteLine("Enter a random word.");
            string userInput = Console.ReadLine();
            string reverseInput = null;

            // Loops through each character in reverse order and adds them to the string reverseInput.
            for (int i = userInput.Length -1; i > -1; i--)
            {
                reverseInput += userInput[i];
            }
            Console.WriteLine(reverseInput);
        }
    }
}
