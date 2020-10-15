using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Questions_9_10_Test2
{
    // Name: Jacob Goodwillie
    // Date: 10/14/2020
    /* Description: This program is based off of my schuml
     * design. I created a gaming abstract class that could be applied
     * both to running a game and a gamer. The gamer class inherits from both
     * the gaming class and gamer interface. The run game class inherits from
     * the game selected interface and gaming class. The myMethod function takes 
     * and object and based on what type of object it is, it calls its specific functions.
     * The function also uses casting to tell the computer what type of object's functions to use.
     * 
     */
    class Program
    {
        static string whatGame;
        static void Main(string[] args)
        {
      
            RunGame gameRunning = new RunGame();
            Gamer gamer = new Gamer("Jacob");

            MyMethod(gameRunning);
            gamer.gameName = whatGame;
            MyMethod(gamer);
        }

        static void MyMethod(object obj)
        {
            if (obj is RunGame)
            {
                RunGame gameIsRunning = (RunGame)obj;
                whatGame = gameIsRunning.selectGame("Resident Evil");
                Console.WriteLine("You have selected " + whatGame + " and have played for " + gameIsRunning.hoursPlayed + " hours.");
            }
            else if (obj is Gamer)
            {
                Gamer thisGamer = (Gamer)obj;
                thisGamer.playGame();
                thisGamer.gamingHours(5);
                thisGamer.sleep();
            }
        }
    }

    // Public abstract class gaming which gamer and rungame inherit.
    public abstract class Gaming
    {
        public string genre;
        public string gameName;
        public int hoursPlayed;



        public virtual void gamingHours(int hours)
        {
            hoursPlayed = hours;
            Console.WriteLine("has played " + this.gameName + " for " + hoursPlayed + " hours.");
        }
    }
    // Interface that only gamer inherits from.
    public interface IGamer
    {
        void playGame();
        void sleep();
    }
    // Interface that only rungame inherits from.
    public interface IGameSelected
    {
        string selectGame(string game);
    }
    // Gamer class which displays different texts for different actions.
    public class Gamer : Gaming, IGamer
    {
        string name { get; set; }

        public Gamer(string _name)
        {
            this.name = _name;
        }
        public void playGame()
        {
            Console.WriteLine(this.name + " wants to play " + this.gameName);
        }
        public void sleep()
        {
            Console.WriteLine(this.name + " is sleeping...");
        }

        public override void gamingHours(int hours)
        {
            Console.WriteLine(this.name + " has played " + this.gameName + " for " + this.hoursPlayed + " hours.");
        }

    }
    // RunGame which returns the type of game to run.
    public class RunGame : Gaming, IGameSelected
    {
        public string selectGame(string game)
        {
            return game;
        }
    }
}

