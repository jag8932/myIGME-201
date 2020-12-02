using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Extra_Credit_Madder_Libs
{
    // Name: Jacob Goodwillie
    // Date: 12/1/2020
    /* Description: This program is like the game madlibs. It reads through a file and the user selects
     * the story they want to use. The program determines where the user is prompted; for example if 
     * the word {adjective} appears, the user is prompted for an adjective. A bit buggy but overall
     * does what it intends to do.
     */
    class Program
    {

        // Result string declared as a global variable since functions 
        // bellow Main() use it.
        // Creates a list to store previously entered words.
        static string resultString = "";
        static List<string> previousTerms = new List<string>();
        static void Main(string[] args)
        {
            // Declare variables such as the filepath, array to hold the file lines, etc...
            string filePath = @"C:\github\jag8932\Extra_Credit_Madder_Libs\MadLibsTemplate.txt";
            string[] libLines = File.ReadAllLines(filePath);
            int maxLines = libLines.Length;
            string previousWords = libLines[maxLines - 1];
            string[] eachPrevWord = previousWords.Split();
            bool stepOne = false;
            bool stepTwo = false;
            int select;
            

            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            // Ask user if they want to play game. Exit application if they say no.
            do
            {
                Console.WriteLine("Would you like to play Mad Libs " + name + "?");
                string answer = Console.ReadLine();
                if (answer == "yes" || answer == "Yes")
                {
                    stepOne = true;
                } else if (answer == "no" || answer == "No")
                {
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                }
            } while (!stepOne);
            // Check which madlibs the user wants to play 1-6.
            do
            {
                Console.WriteLine("Enter a number between 1 and 6.");
                stepTwo = int.TryParse(Console.ReadLine(), out select) && select > 0 && select < 7;
            } while (!stepTwo);
            Console.WriteLine("You have selected prompt " + select);
            string[] selectedStory = libLines[select -1].Split();


            // This foreach function handles the main program. It checks each line
            // and breaks it up into individual words. Checks to see if the word is a prompt, if so
            // it calls the function prompt to get the user's input. It also adds everything to result
            // string so the user can see their choices at the end.
            foreach (string line in selectedStory)
            {
                
                if (line == "\n")
                {
                    resultString += Environment.NewLine;
                } 
                 if (line[0] == '{')
                {
                    string trimmed = line.Trim('{', '}');
                    foreach (char chars in trimmed)
                    {
                        if (chars == '_')
                        {
                            trimmed = trimmed.Replace(chars, ' ');
                        }
                    }
                    // Checks if there is already stored data. The stories end at 6 so everything else
                    // is considered saved data.
                    if (maxLines > 6)
                    {
                        for (int i = 0; i < eachPrevWord.Length; i++)
                        {
                            // Compare the previous terms with the new terms
                            // If they are both, for example an adjective use the 
                            // same prompt from last time which can be found to the right
                            // off 'eachPrevWord[i]'.
                            if (eachPrevWord[i] == trimmed)
                            {
                                string nextWordOver = eachPrevWord[i + 1];
                                resultString += " " + nextWordOver;
                            } 
                        }
                    } else { prompt(trimmed); }
                   
                // Just add the line as is.
                }
                else
                {
                    resultString += " " +line;
                }
            }

            
            Console.Write(resultString);
            Console.WriteLine("Save your inputs?");
            string answer2 = Console.ReadLine();
            if (answer2 == "yes") { changeTemplate(); }
            

            // This function saves previous words and adds them to the textfile using the 
            // File.AppendAllText() function. It creates a new line each time it is used to 
            // save a new batch of previous used terms.
            void changeTemplate()
            {
                string savedWords = "";
                for (int i = 0; i < previousTerms.Count; i++)
                {
                    savedWords += previousTerms[i] + " ";
                    
                }
                File.AppendAllText(filePath, Environment.NewLine + savedWords);
            }
        }

        // Prompts user for input and adds it to the previous terms list.
        // Adds user input to result string
        static void prompt(string word)
        {
            Console.WriteLine(word + ":");
            saveInput(word);
            string input = Console.ReadLine();
            resultString += " " + input;
            saveInput(input);

        }
        // Adds to previous terms list.
        static void saveInput(string input)
        {
            previousTerms.Add(input);
    
        }

    }
}
