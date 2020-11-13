using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] mas =  { 10, 5, 2, 3, 6, 8, 2, 1 };
            //PrintArray(mas);
            //Array.Sort(mas, Comp);
            //PrintArray(mas);

            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog("Полкан", 12, 120);
            dogs[1] = new Dog("Шарик", 12, 120);
            dogs[2] = new Dog("Тузик", 15, 80);

            PrintArray(dogs);
            Array.Sort(dogs);
            PrintArray(dogs);
            Console.ReadKey();

        }

        static void PrintArray(int[] a)
        {
            foreach (var item in a)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();
        }
        static void PrintArray(Dog[] a)
        {
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int Comp(int a, int b)
        {
            return b-a; 
        }
    }
}
