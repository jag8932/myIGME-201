using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Questions_9_10_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
         public string gameBeingPlayed;
        RunGame runGame = new RunGame();
        Gamer gamer = new Gamer("Jason");
    }
           }


    


    public abstract class Gaming
    {
        public string genre;
        public string gameName;
        public int hoursPlayed;



        public virtual void gamingHours(int hours)
        {
             Console.WriteLine("has played " + this.gameName + " for " + this.hoursPlayed + " hours.");
        }
    }

    public interface IGamer
    {
         void playGame();
        void sleep();
    }

    public interface IGameSelected
    {
        string selectGame(string game);
    }
    public class Gamer : Gaming , IGamer
    {
        string name { get; set;}

        public Gamer(string _name)
        {
            this.name = _name;
        }
        public  void playGame()
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

    public class RunGame : Gaming, IGameSelected
    {
        public string selectGame(string game)
        {
            return game;
        }
    } 
}
