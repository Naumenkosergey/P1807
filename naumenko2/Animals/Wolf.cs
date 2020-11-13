using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Wolf:Animal
    {
        public Wolf()
        {
        }

        public Wolf(string food, float hunger, string location, float boundaries) : base(food, hunger, location, boundaries)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("АУУУФ");
        }

        public override void Eat()
        {
            Console.WriteLine("Я волк, схвал крола!");
        }
    }
}
