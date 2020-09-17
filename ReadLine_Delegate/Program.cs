using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine_Delegate
{
    class Program
    {
        // Name: Jacob Goodwillie
        // Date 9/16/ 2020
        // Unit 1 test

        // Creates a delegate function based off of the console.readline
        // function. A string sentence is created to test the new readline function
        // and then displays it to the console.

        delegate string NewReadLine(); //Delegate declared.
        static void Main(string[] args)
        {
            NewReadLine newReadLine; // Function of the delegate is created.

            newReadLine = new NewReadLine(Console.ReadLine); //Console.ReadLine is passed into the new function.

            Console.WriteLine("Write a random sentence");
            string testSentence = newReadLine(); // Tests a string using the new function and outputs it to console.
            Console.WriteLine(testSentence);
        }
    }
}
