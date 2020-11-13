using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab11
{
    public class SortByName : IComparer                               //
    {
        int IComparer.Compare(object ob1, object ob2)
        {
            Monster m1 = (Monster)ob1;
            Monster m2 = (Monster)ob2;
            return string.Compare(m1.Name, m2.Name);
        }
    }
}
