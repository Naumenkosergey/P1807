using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonInterface
{
    class Dog : IComparable<Dog>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double Size { get; set; }

        public Dog(string name, int age, double size)
        {
            Name = name;
            Age = age;
            Size = size;
        }

        public Dog()
        {
        }

        public override string ToString()
        {
            return $"Собака {Name} возраст {Age} размер {Size}";
        }

        public int CompareTo(Dog other)
        {
            return Size.CompareTo(other.Size);
        }
    }
}
