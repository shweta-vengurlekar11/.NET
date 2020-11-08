using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16
{
    class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Employee(int id, string nm, double sal, string dept)
        {
            Id = id;
            Name = nm;
            Salary = sal;
            Department = dept;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Id, Name, Salary, Department);
        }
    }
    class q1
    {
        static void Main(string[] args)
        {
            Employee[] e = new[]
                {
            new Employee(1, "shweta", 82000, "HR"),
            new Employee(2, "vikas", 13000, "Developer"),
            new Employee(3, "pqr", 28000, "Developer"),
            new Employee(4, "lmn", 18000, "HR"),
            new Employee(5,"viren",26000,"Back-office")
        };

            //foreach (Employee d in e)
            //    Console.WriteLine(d);
            e.ToList().ForEach(a => Console.WriteLine(a));

            Console.WriteLine("---------------------");

            var odername = from d in e group d by d.Department into g select g;
            foreach (var o in odername)
            {
                Console.WriteLine(o.Key);
                foreach (var a in o)
                    Console.WriteLine("{0}", a);
                Console.WriteLine();
            }

            Console.WriteLine("---------------------");

            var odername1 = from d in e group d by d.Department into g select new { dept = g.Key, emp = g };
            foreach (var o in odername1)
            {
                Console.WriteLine(o.dept);
                foreach (var a in o.emp)
                    Console.WriteLine("{0}", a);
                Console.WriteLine();
            }

        }
    }
}
