using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_15
{
    class q4
    {
        static void Main()
        {
            Console.WriteLine("enter 5 names");
            string[] namearr = new String[5];
            for (int i = 0; i < namearr.Length; i++)
            {
                namearr[i] = Console.ReadLine();
            }
            Console.WriteLine("array starting with v");
            IEnumerable<string> arr1 = from g in namearr
                                       where g.StartsWith("v")
                                       select g;
            foreach (string d in arr1)
                Console.WriteLine(d);
            
        }

    }
}

