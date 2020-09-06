using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Question8_Goodwillie
{

    // Name: Jacob Goodwillie
    // Date: 9/5/2020
    // Assignment: #8 question 8
    class Program
    {

        // This app reads the user's input and if it detects 'no' in the input it will replace it with 'yes'.
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence using the word 'no' atleast once.");
            string userSentence = Console.ReadLine();
            // I used the Replace() function to detect any 'no's.
            userSentence = userSentence.Replace("no", "yes");
            Console.WriteLine(userSentence);
        }
    }
}
