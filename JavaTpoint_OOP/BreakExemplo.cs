using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaTpoint_OOP
{
    internal class BreakExemplo
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 100000; i++)
            {
                if (i == 4000)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            
        }
    }
}
