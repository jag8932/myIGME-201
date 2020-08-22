using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goodwillie_PE1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created an array for names and a boolean variable to control the while loop.
            string[] names = { "Jacob", "Ryan", "Jessica", "Bethany", "Nick" };
            bool isTrue = false;
            // Prints the names in the array to the console.
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Hello " +  names[i] + "!");
            }
            // This section will ask the user a math question. If the user answers correctly
            // they will break out of the loop. If they don't answer correctly, the console
            // will continue to ask them the math question until they answer correctly.
            while (isTrue == false)
            {
                Console.WriteLine("What's 9 X 10?");
                string answer = Console.ReadLine();
                if (answer != "90")
                {
                    Console.WriteLine("That answer is incorrect.");
                }
                else if (answer == "90")
                {
                    Console.WriteLine("Correct answer!");
                    isTrue = true;
                }
            }
            
        }
    }
}
