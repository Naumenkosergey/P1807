using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonClasses
{
    class Animal
    {
        float mass { get; set; }
        char gender;
        int age;
        public string name;
        char Gender
        {
            get
            {
                return Gender1;
            }
            set
            {
                Gender1 = value;
            }
        }

        public char Gender1 { get => gender; set => gender = value; }
        public string Age
        {
            get
            {
                if (age == 1 || (age > 20 && age % 10 < 2))
                    return age + " god";
                else if (age > 1 && age < 5 || (age > 20 && age % 10 < 5 && age % 10 > 1))
                    return age + " goda";
                else
                    return age + " let";
            }
            set
            {
                while (true)
                {
                    value = Console.ReadLine();
                    if (int.Parse(value) < 0 || int.Parse(value) > 15)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        age = int.Parse(value);
                        break;
                    }
                }
            }
        }

        public Animal(string name, char gender, int age, int mass)
        {
            this.name = name;
            Gender1 = gender;
            Age = age.ToString();
            this.mass = mass;
        }

        public void Say()
        {

        }
        public Animal() { }
    }
}
