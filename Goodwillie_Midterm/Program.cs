using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Goodwillie_Midterm
{
    class Program
    {
        // Name: Jacob 
        // Date: 9/16/2020
        // Unit 1 Test

        // Recreates the 3 questions program. Will prompt user to choose a number 1-3 and display a question based on input.
        // User has to guess correct answer within 5 seconds or else they will be asked to play again.

        static bool programRun = true;
        static string[] questionPrompt = { "What is your favorite color?", "What is the answer to life, the universe and everything?", "What is the airspeed velocity of an unladen swallow?"};
        static string[] answers = { "black","42" , "What do you mean? African or European swallow?" };
        static int questionNum;
        static string finalAnswer;
        static void Main(string[] args)
        {

            bool isValid = false;
            bool numValid = false;
           
                while (!isValid) { 
                    
                Console.WriteLine("Choose your question (1-3):");
                bool checkValid = int.TryParse(Console.ReadLine(), out questionNum);
                if (questionNum > 3 || questionNum < 1)
                {
                    Console.WriteLine("Number invalid, try again.");
             
                } else if (questionNum < 4 && questionNum > 0)
                    {
                        numValid = true;
                        }
                    
                if (checkValid && numValid)
                {
                    isValid = true;
                }
                }
                assignAnswer();
                Console.WriteLine("You have 5 seconds to answer the following question:");
                Console.WriteLine(questionPrompt[questionNum -1]);
                startTimer();
            Console.WriteLine("You're out of time!");

                void startTimer() {
                int time = 50000;
                bool timeLeft = true;
                while(timeLeft)
                {
                    time--;
                    if (time == 0)
                    {
                        timeLeft = false;
                    }
                }
                 }
            
                void assignAnswer()
            {
  
                    finalAnswer = answers[questionNum - 1];
 
            }
        }


    }

      
}
