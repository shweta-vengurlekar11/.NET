// . Accept two name from user and concat.

using System;

namespace day_2
{
    class q4
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.WriteLine("enter two names");
            a = Console.ReadLine();
            b = Console.ReadLine();
            Console.WriteLine("concat of {0} and {1} is :{2}", a, b, a + b);
        }

    }
}

