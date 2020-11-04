using System;
using System.IO;

namespace CS_draw_grid_prob
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] grid = new char[4, 4];
            for (int r = 0; r < 4; ++r)
            {
                for (int c = 0; c < 4; ++c)
                {
                    //grid[r, c] = '0';
                    grid[r, c] = ' '; // ***
                }
            }

            ShowGrid(grid);
            Console.ReadLine();

            grid[3, 3] = '1';
            Console.Clear();
            ShowGrid(grid);
            Console.ReadLine();

            grid[3, 3] = ' ';
            grid[2, 2] = '2';
            grid[0, 2] = 'E';
            grid[1, 3] = 'A';
            Console.Clear();
            ShowGrid(grid);
            Console.ReadLine();
        }

        static void ShowGrid(char[,] g)
        {
            for (int r = 0; r < 4; ++r)
            {
                for (int c = 0; c < 4; ++c)
                {
                    Console.Write("[{0}]", g[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}