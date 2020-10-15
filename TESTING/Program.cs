using System;

namespace TESTING
{
    class Program
    {
        static int charX = 0;
        static int charY = 0;
        static string[,] world = new string[40,40];
        static void Main(string[] args)
        {
            for(int x = 0; x < 40; x++)
            {
                for(int y = 0; y < 40; y++)
                {
                    if (x != charX && y != charY) { 
                    world[x, y] = "O";
                    }
                }
            }
            Console.WriteLine(world[charX, charY]);
            Console.WriteLine("Hello World!");
            for (var i = 0; i < 10; i++)
            {
                Console.Write("O");
            }
        }
      string uhhh =  Console.ReadLine();
    }
}
