using System;
namespace emplibrary
{
    public class Employee
    {
        int id,getid=0;
        string name;
        double salary, netsal;
        static double tds = 0.1;
        const int maxsal = 50000;
        const int maxcapacity = 3;
        static Employee()
        {
            Console.WriteLine("welcome to visual IT");
        }
        public Employee(string name, double salary)
        {
            if (salary < maxsal)
            {
                if (getid < maxcapacity && salary>0)
                {
                    id = ++getid;
                    this.name = name;
                    this.salary = salary;
                }
                else
                    throw new Exception("salary cant negative or 0");
            }
            else
            {
                throw new Exception("salary cant be more than 50000");
            }
        }
        public static void calculate_netsal(Employee obj)
        {
            obj.netsal = obj.salary - (obj.salary * tds);
        }
        public string Name
        {
            get;
            set;
        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < maxsal)
                {
                    if (value > 0)
                    {
                        salary = value;
                    }
                    else
                    {
                        throw new Exception("salary cant negative or 0");
                    }
                }
                else
                    throw new Exception("salary cant be more than 50000");
            }
        }
        public string dsiplay()
        {
            return String.Format("{0} {1} {2}", name, salary, netsal);
        }
    }
}
