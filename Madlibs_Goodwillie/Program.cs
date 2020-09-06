using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace Madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;

            StreamReader input;

            // open the template file to count how many Mad Libs it contains
            input = new StreamReader(@"MadLibsTemplate.txt");

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }
            // close it
            input.Close();

            // only allocate as many strings as there are Mad Libs
            string[] madLibs = new string[numLibs];

            // read the Mad Libs into the array of strings
            input = new StreamReader(@"MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[cntr] = line;

                // replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");
                ++cntr;
            }
            
            input.Close();

            bool askUser = false;
            while (!askUser)
            {
                // prompt the user for which Mad Lib they want to play (nChoice)
                Console.WriteLine("Which Mad Lib would you like to play? 0-" + (numLibs-1));

                askUser = int.TryParse(Console.ReadLine(),out nChoice);
                Console.WriteLine(" ");
            }
            // split the Mad Lib into separate words
            string[] words = madLibs[nChoice].Split(' ');
            
            foreach (string word in words)
            {
                Console.WriteLine(word);
                /*
                string result = null;
                char[] checker = {' '};
                string[] tempChar = word.Split(checker);
                foreach(string x in tempChar)
                {
                    if (x == "{Adjective}")
                    {
                        Console.WriteLine("Choose and adjective");
                        result = Console.ReadLine();
                    }
                } */




                // if word is a placeholder
                // prompt the user for the replacement
                // and append the user response to the result string
                // else append word to the result string
            }

            void testWord( string x)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if ()
                }
            }
        }
    }
}
