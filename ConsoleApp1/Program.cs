using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                function(n);
            }
        }

        private static void function(int v)
        {
            if (v % 10 == 1 && v / 10 != 1)
                Console.WriteLine($"{v} год");
            else if ((v % 10 == 2 || v % 10 == 3 || v % 10 == 4) && v / 10 != 1)
                Console.WriteLine($"{v} года");
            else
                Console.WriteLine($"{v} лет");
        }
    }
}
