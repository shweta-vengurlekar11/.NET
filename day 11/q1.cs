using System;
delegate void cal(int a);
namespace day11
{
    static class calculation
    {
        public static void fact(int a)
        {
            int temp = a;
            for (int i = 2; i <= a; i++)
            {
                temp *= i;
            }
            Console.WriteLine("{0}", temp);
        }

        public static void square(int a)
        {
            Console.WriteLine("{0}", a * a);
        }
        public static void cube(int a)
        {
            Console.WriteLine("{0}", a * a * a);
        }

    }
    class q1
    {
        static void Main()
        {
            cal c = new cal(calculation.fact);
            c(5);
            c = new cal(calculation.square);
            c(5);
            c = new cal(calculation.cube);
            c(5);
        }
    }
}
