using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaTpoint_OOP
{
    internal class LoopforeachNome
    {
        public static void Main(string[] args)
        {
            string[] nome = { "Leonardo", "Gabriel Amaral", "Isaac", "Fellype","Samara","Jailson Teminator 3000" };
            foreach (string i in nome)
            {
                Console.WriteLine(i);
            }
        }
    }
}
