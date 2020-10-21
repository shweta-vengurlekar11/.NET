//Create struct emp having member name and salary, using constructor initialized member. Write display method which will display name and salary.
using System;
namespace day_3
{
    struct emp
    {
        public string name;
        public double salary;
        public emp(string ename, double esalary)
        {
            name = ename;
            salary = esalary;
        }
        public void display()
        {
            Console.WriteLine("{0} , {1} ", name, salary);
        }
    }
    class q3
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.WriteLine("enter a name");
            a = Console.ReadLine();
            Console.WriteLine("enter a salary");
            b = Console.ReadLine();
            double sal = double.Parse(b);
            emp e = new emp(a, sal);
            e.display();
        }
    }
}
