using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var reg = Console.ReadLine();
            var regex = new Regex(reg, RegexOptions.IgnoreCase);
            Console.WriteLine(regex.Matches(text).Count);
            
            
        }
    }
}
