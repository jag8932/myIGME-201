using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Question9_Goodwillie
{
    // Name: Jacob
    // Assignment: #8 question 9
    // Date: 9/5/2020
    class Program
    {
        /* This application asks the user for a sentence. The sentence is then broken down into an array
         * by detecting spaces in the string. Then each element of that array has quotation marks added before
         * and after it. This effectively wraps each word in quotation marks.
         */
        static void Main(string[] args)
        {
            // Created a string variable holding the quotation mark. Easier to type the string name than \".
            Console.WriteLine("Write a sentence.");
            string userSentence = Console.ReadLine();
            string quoteMark = "\"";

            // Splits the string at spaces and creates an array of words. 
            string[] sentence = userSentence.Split(' ');

            for (int i = 0; i < sentence.Length; i++)
            {
                sentence[i] =quoteMark + sentence[i] + quoteMark + " ";
                Console.Write(sentence[i]);
            }
           
        }
    }
}
