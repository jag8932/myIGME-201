using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Give_Raise
{
    // Name: Jacob Goodwillie
    // Date: 9/16/2020
    // Unit test 1
    class Program
    {
        // Program gives a raise to you if your name is my name. Or if you have a nickname close enough to mine. 
        static string sName;
        static double dSalary = 3000; // Initial salary is 3000.
        static void Main(string[] args)
        {


            Console.WriteLine("What is your name?");
            sName = Console.ReadLine();

            // Check if give raise returns true. If so then congradulate the user, otherwise tell them why they didn't get a raise.
            if (GiveRaise(sName, ref dSalary))
            {
                Console.WriteLine("Congradulations! Your salary has been increased by 19,999.99! You now have " + dSalary + " dollars!");
            }
            else
            {
                Console.WriteLine("No raise for you, your name is not Jacob.");
            }
            
        }
        static bool GiveRaise(string name, ref double salary)
        {
            // If string name is my name or a nick name, give raise and return true.
            if (name == "Jacob" || name == "jacob" || name == "Jake" || name == "jake")
            {
                dSalary += 19999.99; // Add the raise and congradulate the user. Return true at end.

                return true;
            }
            else
            { // return false.

                return false;
            }
        }
    }
}
