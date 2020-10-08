using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public static int Sum(params int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine(Sum(1, 2, 3, 5, 6));
            Console.WriteLine(Sum(1, 2, 3, 7));
            Console.WriteLine(Sum(1, 2, 3, 9, 10, 15));
        }
    }
}
