using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        private string food;
        private float hunger;
        private string location;
        private float boundaries;

        public Animal()
        {
            Console.WriteLine("Я зверь!!!");
        }

        public Animal(string food, float hunger, string location, float boundaries):this()
        {
            Food = food;
            Hunger = hunger;
            Boundaries = boundaries;
            Location = location;
        }

        public string Food { get => food; set => food = value; }
        public float Hunger { get => hunger; set => hunger = value; }
        public float Boundaries { get => boundaries; set => boundaries = value; }
        public string Location { get => location; set => location = value; }

        public virtual void MakeNoise() { Console.WriteLine("Я зверь, я нашумел"); }
        public virtual void Eat() { Console.WriteLine("Я зверь, я поел"); }
        public virtual void Sleep() { Console.WriteLine("Я зверь, я поспал"); }
        public virtual void Roam() { Console.WriteLine("Я зверь, я че-то сделал"); }

        public override string ToString()
        {
            return "Я Animal";
        }
    }
}
