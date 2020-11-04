using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class q3
    {
        static void Main(string[] args)
        {
            Querytoevennums();
        }
        static void Querytoevennums()
        {
            int[] arr = new int[5];
            Console.WriteLine("enter 5 elements");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            var result = arr.Where(a => a % 2 == 0);
            Console.WriteLine("new array is:");
            foreach (var item in result)
                Console.WriteLine(item);
        }
    }
}
