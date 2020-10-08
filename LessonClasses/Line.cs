using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonClasses
{
    class Line
    {
        Point start;
        Point end;
        public Line(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }

        public double GetLineLength()
        {
            Console.WriteLine($"Длина отрезка оганиченного точками A({start.X},{start.Y}) B({end.X},{end.Y})");
            return Math.Sqrt(Math.Pow(start.X - end.X, 2) + Math.Pow(start.Y - end.Y, 2));
        }

    }
}
