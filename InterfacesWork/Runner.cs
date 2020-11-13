using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesWork
{
    class Runner
    {
        static void Main(string[] args)
        {
            Dog[] dogs = new Dog[1];
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i] = new Dog();
                Console.WriteLine("Введите имя собаки");
                dogs[i].Name = Console.ReadLine();
                //string name = Console.ReadLine();
                Console.WriteLine("Введите возраст собаки (целое число)");
                dogs[i].Age = Console.ReadLine();
                //int age=5;
                //int.TryParse(Console.ReadLine(),out age);
                Console.WriteLine("Введите размер собаки (дробное число)");
                dogs[i].Size = double.Parse(Console.ReadLine());
                //double size = double.Parse(Console.ReadLine());
                //dogs[i] = new Dog(name, age, size);
            }
            PrintArray(dogs);
            Array.Sort(dogs);
            PrintArray(dogs);
            Console.ReadKey();
        }

        static void PrintArray(Dog[] dogs)
        {
            foreach (var item in dogs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------");
        }
    }
}
