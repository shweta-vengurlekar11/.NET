using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_15
{
    class q2
    {
        static void Main()
        {
            Console.WriteLine("enter 5 elements");
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < 5; i++)
            {
                hs.Add(arr[i]);
            }
            Console.WriteLine("\nunique array:");
            foreach (var d in hs)
            {
                Console.WriteLine(d);
            }
        }
    }
}
