using System;
using ClassLibrary_day21;

namespace ConsoleApp_shared_assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int no, sqr, cube;
            calculate c = new calculate();
            Console.WriteLine("enter a number");
            a = Console.ReadLine();
            no = Int32.Parse(a);
            sqr = c.sqr(no);
            cube = c.cube(no);
            Console.WriteLine("square :{0} \ncube :{1}", sqr, cube);
        }
    }
}
