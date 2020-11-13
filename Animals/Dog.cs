using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal
    {
        public string Pedigri { get; set; }
        public Dog()
        {
        }

        public Dog(string pedigri, string food, float hunger, string location, float boundaries) 
            : base(food, hunger, location, boundaries)
        {
            Pedigri = pedigri;
        }
    }
}
