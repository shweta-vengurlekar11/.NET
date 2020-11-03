using System;
delegate void cal(int a);
namespace day11
{
    class calculation
    {
        public void fact(int a)
        {
            int temp = a;
            for (int i = 2; i <= a; i++)
            {
                temp *= i;
            }
            Console.WriteLine("{0}", temp);
        }

        public void square(int a)
        {
            Console.WriteLine("{0}", a * a);
        }
        public void cube(int a)
        {
            Console.WriteLine("{0}", a * a * a);
        }

    }
    class q1
    {
        static void Main()
        {
            calculation ca = new calculation();
            cal c;
            cal factcal = ca.fact;
            cal sqrcal = ca.square;
            cal cubecal = ca.cube;

            c = factcal;
            c += sqrcal;
            c += cubecal;

            c(5);
        }
    }
}
