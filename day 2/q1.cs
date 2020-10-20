// Accept two number from user and print sum of it.

using System;

namespace day_2
{
    class q1
    {
        static void Main(string[] args)
        {
            string a, b;
            bool x, y;
            int p, q, sum = 0;
            Console.WriteLine("enter nos");
            a = Console.ReadLine();
            b = Console.ReadLine();

            x = Int32.TryParse(a, out p);
            y = Int32.TryParse(b, out q);
            if (x == true && y == true)
            {
                sum = p + q;
                Console.WriteLine("sum of {0} and {1} is :{2}", p, q, sum);
            }

        }
    }
}
