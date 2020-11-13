using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab11
{
    class Runner
    {
        static void Main()
        {
            const int n = 3;
            Monster[] monsters = new Monster[n];

            monsters[0] = new Monster(50, 50, "Вася");
            monsters[1] = new Monster(80, 80, "Петя");
            monsters[2] = new Monster(40, 10, "Маша");

            Console.WriteLine("Сортировка по имени:");
            try
            {
                Array.Sort(monsters, new SortByName());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.GetType());
            }
            foreach (Monster elem in monsters)
                Console.WriteLine( elem);

           
            Console.ReadKey();
        }
    }
}


