using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaTpoint_OOP
{
    internal class Loopforeach
    {
        public static void Main (string[] args)
        {
            string[] car = { "BWM", "UNO", "VOLVO", "FERRARI" };
            foreach (string i in car)
            {
                Console.WriteLine (i);
            }
        }
    }
}
