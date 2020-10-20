// Accept a number from user and print square of it, if in put is not valid give appropriate message

using System;

namespace day_2
{
    class q5
    {
        static void Main(string[] args)
        {
            string a;
            bool x, y;
            int p;
            Console.WriteLine("enter no");
            a = Console.ReadLine();

            x = Int32.TryParse(a, out p);
            if (x == true && p != 0)
            {
                Console.WriteLine("square of {0} is :{1}", p, p * p);
            }
            else
            {
                Console.WriteLine("error...give interger number");
            }

        }
    }
}
