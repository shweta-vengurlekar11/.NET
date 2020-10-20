using System;

namespace day1
{
  class demomath
    {
         public float sqr(float a)
        {
            return (a * a);
        }
         public float cube(float a)
        {
            return (a * a *a);
        }

    }
    class q5
    {
        static void Main(string[] args)
        {
            float a = 26.35f;
            demomath d = new demomath();
            Console.WriteLine("sqr :" +d.sqr(a));
            Console.WriteLine("cube :" + d.cube(a));
        }
    }
}