using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Monster //: IComparable<Monster>
    {
        int health;
        int ammo;

        public int Ammo
        {
            get { return ammo; }
            set
            {
                if (value > 0) ammo = value;
                else ammo = 0;
            }
        }

        public string Name
        {
            get;
            set;
        }

        public Monster(int health, int ammo, string name)
        {
            this.health = health;
            Ammo = ammo;
            Name = name;
        }

        public override string ToString()
        {
            return $"Monster {Name} \t health = {health} ammo = {Ammo}";
        }

        public int CompareTo(Monster other)
        {
            return health - other.health;
        }
    }
}
