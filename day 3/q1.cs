//Create a struct Math having two method square and cube. 
//Using struct variable call this method and print square and cube of a number
using System;

namespace day_3
{
    struct Math
    {
        public void sqr(int x)
        {
            Console.WriteLine("square :" + x * x);
        }
        public void cube(int x)
        {
            Console.WriteLine("cube :" + x * x * x);
        }
    }
    class q1
    {
        static void Main()
        {
            Math m = new Math();
            Console.WriteLine("enter a number");
            string num = Console.ReadLine();
            int a = Int32.Parse(num);
            m.sqr(a);
            m.cube(a);
        }
    }
}
