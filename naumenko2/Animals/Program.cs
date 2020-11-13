using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("мясо", 5, "Дом", 7);
            Animal dog = new Dog("кавказец","людей",15,"всеядный",15.5f);
            Animal animal = new Animal();
            Console.WriteLine(cat);
            Console.WriteLine(dog);
            Console.WriteLine(animal);
        }
    }
}
