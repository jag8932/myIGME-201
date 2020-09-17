using Microsoft.Win32;
using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Name: Jacob Goodwillie
        // Date: 9/16/2020
        // Midterm
        
        // The task of the assignment was to find errors, logical, runtime, or compiletime and fix them. 
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //  int nY --> missing semicolon. Compile time error.
            int nY;
            int nAnswer;

          //  Console.WriteLine(This program calculates x ^ y.); --> Missing quotation marks. Syntax error so this is a compile time error.

            do
            {
                Console.Write("Enter a whole number for x: ");
                // Console.ReadLine(); --> Not assigning user input to anything. Runtime error.
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX)); // Before I corrected the previous error, this had a compile time error since sNumber wasn't defined.

            /*
            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();                               <--- Outputs nX instead of nY. This is a logical error.
            } while (int.TryParse(sNumber, out nX));
            */
            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
                // while (int.TryParse(sNumber, out nY)); Should be checking if the boolean is false to keep the user in the loop. Logic error.
            } while (!int.TryParse(sNumber, out nY));
            // compute the factorial of the number using a recursive function
            // nAnswer = Power(nX, nY); Creates an error since currently the power function doesn't return a value.
            nAnswer = Power(nX, nY);

            //  Console.WriteLine("{nX}^{nY} = {nAnswer}"); Wrong way of creating a string with an order. Logic error.
            Console.WriteLine("{0} ^ {1} = {2}", nX, nY, nAnswer);
        }

        // int Power needs to be static since it is out of Main. Logic error.
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
              int nextVal = 0;
           
            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                // returnVal = 0; Should return 1. An exponent to the power of 0 is 1. Logic error.
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                // nextVal = Power(nBase, nExponent + 1); Will create a stackoverflow since it is increasing the exponent rather
                // than decreasing. We want to recurse until the exponent is zero. This is a runtime error.
                nextVal = Power(nBase, nExponent - 1);
                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            // returnVal; Missing return before returnVal. This will cause a compiletime error.
            return returnVal;
        }
    }
}
