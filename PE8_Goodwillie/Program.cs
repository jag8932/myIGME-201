using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Goodwillie
{
    class Program
    {
        // QUESTION 2:
        // Enum color works as a short or as a byte type.
        enum Color : short
        {
            red,
            orange,
            yellow,
            green,
            blue,
            indigo,
            violet,
            black,
            white
        }
        static void Main(string[] args)
        {
            // QUESTION 3:
            // Declares an array of doubles to a size of 4.
            double[] percipitation = new double[4];
            percipitation[0] = 0.45;
            percipitation[1] = 2.78;
            percipitation[2] = 0.04;
            percipitation[3] = 1.22;

            Color firstColor = Color.red;
            Console.WriteLine(firstColor);

            // QUESTION 4:
            // For loop that assigns ascendingNumbers a value.
            int[] ascendingNumbers = new int[5];
            for (int i = 0; i < ascendingNumbers.Length; i++)
            {
                ascendingNumbers[i] = i + 1;    //Made each value of the array equal to i+1 since
                                                //we don't want the array values to start at 0. We want 1-5 not 0-4.
                Console.WriteLine(ascendingNumbers[i]); //To see the results of the array.
            }

        }

        
    }
}
 