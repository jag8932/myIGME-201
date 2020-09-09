using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9_Goodwillie
{
    // Name: Jacob Goodwillie
    // Date: 9/8/2020
    // Assignment PE9


    /* Description: This simple program creates a delegate function that replaces
     * the console.readline function. It stores the user input in a global variable 
     * and then displays that input. 
      */
    class Program
    {
        //n Stores given by delegate function.
        static string n;
        // delegate function accepts no special parameters in this case. Declared as UserInput.
        delegate void UserInput();

        static void Main(string[] args)
        {
            // Creates variable of delegate to hold the function we want.
            UserInput showInput;
            showInput = new UserInput(readLine); // Gives the variable the delegate function.

            Console.WriteLine("What is your name?");
            showInput();    // ShowInput does exactly the same thing as Console.ReadLine and gives n a string based on user input.
            Console.WriteLine("Hello " + n);

            order numberOne = new order();

            numberOne.totalprice();
        }
        struct order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;

            public double totalprice()
            {

                return unitCount * unitCost;
            }

            public string showOrder()
            {
                string order = String.Format("You ordered {0} {1} at ${2} per item." , unitCount, itemName, unitCost);
                return order;
            }

        }

        // Static function to be used in the delegate function.
        static void readLine()
        {
            n = Console.ReadLine(); // Sets n to whatever the user types.

        }


    }
}
