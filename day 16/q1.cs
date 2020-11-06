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
        public string Address { get; set; }

        public Employee(int id, string nm, double sal, string address)
        {
            Id = id;
            Name = nm;
            Salary = sal;
            Address = address;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Id, Name, Salary, Address);
        }
    }
    class q1
    {
        static void Main(string[] args)
        {
            Employee[] e = new Employee[4];
            e[0] = new Employee(1, "shweta", 82000, "vile-parle");
            e[1] = new Employee(2, "vikas", 13000, "andheri");
            e[2] = new Employee(3, "pqr", 28000, "kandivali");
            e[3] = new Employee(4, "lmn", 18000, "andheri");

            //foreach (Employee d in e)
            //    Console.WriteLine(d);
            e.ToList().ForEach(a => Console.WriteLine(a));

            Console.WriteLine("----------2----------");

            var result = from d in e where d.Address == "andheri" select d.Name;
            foreach (string d in result)
                Console.WriteLine(d);

            Console.WriteLine("----------3----------");

            var result1 = (from d in e select d.Salary).Sum();
            Console.WriteLine("total of all employee salaries are:{0}", result1);

            Console.WriteLine("----------4----------");

            var result2 = from d in e where d.Name.StartsWith("v") select d.Name;
            foreach (string d in result2)
                Console.WriteLine(d);

            Console.WriteLine("----------5----------");

            var result3 = (from d in e select d.Name).Count();
            Console.WriteLine(result3);

            Console.WriteLine("----------6----------");

            var result4 = from d in e where d.Salary > 50000 select d;
            foreach (Employee d in result4)
                Console.WriteLine(d);

            Console.WriteLine("----------7----------");

            var minsal = (from d in e select d.Salary).Min();
            var maxsal = (from d in e select d.Salary).Max();
            var avgsal = (from d in e select d.Salary).Average();

            Console.WriteLine("minsal:{0} maxsal:{1} avg sal:{2}", minsal, maxsal, avgsal);

            Console.WriteLine("----------8----------");

            var result5 = from d in e orderby d.Name select d.Name;
            foreach (string d in result5)
                Console.WriteLine(d);

            Console.WriteLine("----------9----------");

            var result6 = from d in e orderby d.Salary descending select d.Salary;
            foreach (double d in result6)
                Console.WriteLine(d);

            Console.WriteLine("----------10----------");

            var result7 = from d in e where d.Salary < 20000 select new { Id = d.Id, Name = d.Name };
            foreach (var d in result7)
                Console.WriteLine("{0} {1}", d.Id, d.Name);
        }
    }
}
