using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonClasses
{

    class Runner
    {
        static void Main(string[] args)
        {
            //Animal lion = new Animal("лев", 'м', 10, 2000);

            //Console.WriteLine($"Льву {lion.Age} ");
            //lion.Age = Console.ReadLine();
            //Console.WriteLine($"Льву {lion.Age} ");

            Point a = new Point(1, 2);
            Point b = new Point(3, -4);

            Point c = new Point(3, 4);
            Point d = new Point(10, -15);



            double length = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y,2));
            Console.WriteLine($"Длина отрезка оганиченного точками A({a.X},{a.Y}) B({b.X},{b.Y}) = {length}");

            Line line = new Line(a, b);
            Console.WriteLine(line.GetLineLength());

            Line line2 = new Line(c, d);
            Console.WriteLine(line2.GetLineLength());



        }
    }
}
