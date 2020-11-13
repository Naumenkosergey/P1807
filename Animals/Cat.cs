using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat:Animal
    {
        public Cat(string food, float hunger, string location, float boundaries) : base(food, hunger, location, boundaries)
        {
        }

        public override string ToString()
        {
            return $"Я кот, мои характеристики:\nЕда: {Food}, сытость: {Hunger}, обитаю в: {Location}, граница: {Boundaries}";
        }
    }
}
