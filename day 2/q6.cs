// Accept a number and stored it in byte data type check what happen if you enter 258?

using System;

namespace day_2
{
    class q6
    {
        static void Main(string[] args)
        {
            string a;
            byte b; int x;
            bool status;
            Console.WriteLine("enter number");
            a = Console.ReadLine();
            status = Int32.TryParse(a, out x);

            if (status == true)
            {
                b = (byte)x;
                Console.WriteLine("byte number is :{0}", b);
            }
        }

    }
}

