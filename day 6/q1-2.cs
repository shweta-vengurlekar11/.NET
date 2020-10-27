using System;
using emplibrary;

namespace day_6
{
    class q1_2
    {
        static void Main()
        {
            Employee e = new Employee("shweta", 25000);
            Employee.calculate_netsal(e);
            //e.Salary = 0;
            Console.WriteLine(e.dsiplay());
        }
    }
}
