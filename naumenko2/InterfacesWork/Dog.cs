using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesWork
{
    class Dog : IComparer<Dog>, IComparable
    {
        private int age;
        private double size;

        public string Name { get; set; }
        public string Age
        {
            get
            {
                return age + CheckAgePrint();
            }
            set
            {
                if (int.Parse(value) < 0 || int.Parse(value) > 20)
                {
                    Console.WriteLine("некоректные данные: диапазон [0;20]");
                    Age = Console.ReadLine();
                }
                else
                    age = int.Parse(value);
            }
        }

        public double Size
        {
            get => size;
            set => size = Math.Abs(value);
        }
        public Dog()
        {
        }

        public Dog(string name, int age, double size)
        {
            Name = name;
            Age = age.ToString();
            Size = size;
        }

        public override string ToString()
        {
            return $"Собака по кличке {Name} размер {Size} см, возраст {Age}";
        }

        string CheckAgePrint()
        {
            if (age % 10 == 1 && age / 10 != 1)
                return " год";
            else if ((age % 10 == 2 || age % 10 == 3 || age % 10 == 4) && age / 10 != 1)
                return " года";
            else
                return " лет";
        }
        public int CompareTo(object obj)
        {
            Dog otherDog = obj as Dog;
            if (this.size < otherDog.size)
                return 1;
            else if (this.size > otherDog.size)
                return -1;
            else
                return 0;
        }

        public int Compare(Dog x, Dog y)
        {
            if (x.size < y.size)
                return 1;
            else if (x.size > y.size)
                return -1;
            else
                return 0;
        }
    }
}
