using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Question5_Goodwillie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blab = new string[5];
            blab[4] = "hello";
            
            for (int i = 0; i< blab.Length; i++)
            {
                Console.WriteLine(blab[i]);
            }
        }
    }
}
