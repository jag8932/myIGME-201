using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace toBeDeleted
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteFood = "spaghetti";
            switch (favoriteFood)
            {
                case ("spaghetti"):
                    Console.WriteLine("You seem to really like spaghetti");
                case ("cake"):
                    Console.WriteLine("Wrong. Spaghetti is the best food.");
                    default():  
          Console.WriteLine("You should like spaghetti.");
            }



        }
    }
}
