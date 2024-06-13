using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaTpoint_OOP
{
    internal class BreakExemplo2
    {
        public static void Main (string[] args)
        {
            for (int i = 0; i < 300; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
