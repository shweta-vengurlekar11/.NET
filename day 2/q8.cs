//Accept a float value and print square of that number

using System;

namespace day_2
{
    class q8
    {
        static void Main(string[] args)
        {
            string a;
            float b;
            Console.WriteLine("enter number");
            a = Console.ReadLine();
            // b = float.Parse(a);
            b = Convert.ToSingle(a);
            Console.WriteLine("square of number is :{0}", b * b);

        }

    }
}

