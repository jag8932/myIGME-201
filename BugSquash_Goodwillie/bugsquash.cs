using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: Jacob Goodwillie
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            // Missing semicolon, compile time error.
            // int i = 0


            int i = 0;

            // loop through the numbers 1 through 10
            for (i = 1; i < 10; ++i)
            {
                // declare string to hold all numbers
                // Declaring the wrong type of variable. Should be an int to hold the variable i. 
                // string allNumbers = null;
                   int allNumbers = null;
       
                // output explanation of calculation
                // Console.Write(i + "/" + i - 1 + " = ");

                // i - 1 should be written as a string because this will cause a runtime error.
                // Console.WriteLine(i + "/" + i - 1 + " = ");
                Console.WriteLine(i + "/" + i " - 1  = ");
                // output the calculation based on the numbers
                double result = i / i - 1;
                // d
                // Console.WriteLine(i / (i - 1));
                Console.WriteLine(result);
                // concatenate each number to allNumbers
                // Cannot add a string to an integer in the same variable. Compile time error.
                // allNumbers = i + " ";
                allNumbers = i;

                // Unnecessary increment as the for loop already does that. Logic error.
                // increment the counter
                //   i = i + 1;
                Console.WriteLine("These numbers have been processed: " + allNumbers);
            }
            
            // output all numbers which have been processed
            // Missing the + operator. This is a compile time error. Should also be within the for loop since allNumbers equals i.
            //  Console.WriteLine("These numbers have been processed: " allNumbers);


        }
    }
}
