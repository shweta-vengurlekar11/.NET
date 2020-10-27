using System;
using libraryemp2;

namespace day_5
{
    class q3
    {
        static void Main(string[] args)
        {
            Employee2 e1 = new Employee2(20, "shweta", 80000);
            // Console.WriteLine(e1.dsiplay());
            Employee2 e2 = new Employee2(21, "abc", 10000);
            Employee2.calculate_netsal(e2);
            Console.WriteLine(e2.dsiplay());
        }
    }
}
