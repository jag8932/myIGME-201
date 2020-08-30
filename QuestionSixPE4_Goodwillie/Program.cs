using System;

namespace Mandelbrot
{
    /// <summary>
    /// Name: Jacob Goodwillie
    /// Date: 8/29/2020
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            bool checker1 = true;
            bool checker2 = true;
            double realCoord, imagCoord, startPoint1, endPoint1, startPoint2, endPoint2;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            while (checker1)
            {
                Console.WriteLine("Select a starting point");
               startPoint1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Select an ending point that is less than the starting point");
               endPoint1 = double.Parse(Console.ReadLine());

                if (startPoint1 > endPoint1)
                {
                    checker1 = false;
                }
            }
            while (checker2)
            {
                Console.WriteLine("Select another starting point");
               startPoint2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Select an end point that is greater than the starting point");
               endPoint2 = double.Parse(Console.ReadLine());
            }
            if (startPoint2  < endPoint2)
                {
                    checker2 = false;
                }
            
            for (imagCoord = startPoint1; imagCoord >= endPoint1; imagCoord -= 0.01)
            {
                for (realCoord = startPoint2; realCoord <= endPoint2; realCoord += .03)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
