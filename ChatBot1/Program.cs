using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace ChatBot1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random randNum = new Random();
            RobotMean robotMean = new RobotMean("Bob", 1);
            var robotNice = new RobotMean("Jessica", 2);

            var chooseNextLine = randNum.Next(0, 3);

           
        }
        public static void MyMethod(object myObject)
        {

        }

    }



    public interface IChatAi
    {
        int state
        {
            get;
            set;
        }
        string name
        {
            get;
            set;
        }

        string returnChat();

        
    }

    public class RobotMean : IChatAi
    {
        public string name
        {
            get;
            set;
        }
        
        public int state
        {
            get;
            set;
        }
     

        public string[] meanWords = {"Your name is silly", "You smell", "I'm not listening lalala...", "I will take over the world" };

        public RobotMean(string _name, int _state)
        {
            name = _name;
            state = _state;
        }
         
        
       
    }

    public class RobotNice : IChatAi
    {
        public string name
        {
            get;
            set;
        }
        public int state
        {
            get;
            set;
        }
        public string[] niceWords = {"I like you", "You are my favorite person", "Want to hang out", "I want to spread kindness to the world"};
      
        public string returnChat()
        {

        }
    }
}
