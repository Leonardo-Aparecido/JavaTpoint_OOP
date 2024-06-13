using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaTpoint_OOP
{
    internal class BreakExemplo3
    {
        public static void Main (string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine (i);
                i++;
                if(i == 4)
                {
                    break;
                }
            }
        }
    }
}
