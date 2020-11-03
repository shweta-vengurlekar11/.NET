using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_9
{
    class q3
    {
        static void Main()
        {
            Console.WriteLine("enter a number");
            int a = Int32.Parse(Console.ReadLine());
            Object o = a;
            int b = (int)o;
            Console.WriteLine(o);
            Console.WriteLine(b);
        }
    }
}
