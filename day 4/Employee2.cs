using System;
namespace libraryemp2
{
    public class Employee2
    {
        int id;
        string name;
        double salary, netsal;
        static double tds = 0.1;
        const int maxsal = 50000;
        public Employee2(int id, string name, double salary)
        {
            if (salary < maxsal)
            {
                this.id = id;
                this.name = name;
                this.salary = salary;
            }
            else
            {
                Console.WriteLine("salary cant be more than 50000");
            }
        }
        public static void calculate_netsal(Employee2 obj)
        {
            obj.netsal = obj.salary - (obj.salary * tds);
        }
        public string dsiplay()
        {
            return String.Format("{0} {1} {2}", name, salary, netsal);
        }
    }
}
