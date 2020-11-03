using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14
{
    static class genericex
    {
        public static void swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

    }
    public class Employee
    {
        public int id;
        public string name;
        public string desig;
        public Employee(int id, string nm, string desig)
        {
            this.id = id;
            this.name = nm;
            this.desig = desig;
        }
        public override string ToString()
        {
            return string.Format("id={0} , name={1}, designation={2}", id, name, desig);
        }
    }
    class q2
    {
        static void Main()
        {
            int a = 15, b = 30;
            Console.WriteLine("before swappning a= {0},b= {1}", a, b);
            genericex.swap<int>(ref a, ref b);
            Console.WriteLine("after swappning a= {0},b= {1}", a, b);

            Console.WriteLine();

            double c = 25.36, d = 85.36;
            Console.WriteLine("before swappning c= {0},d= {1}", c, d);
            genericex.swap<double>(ref c, ref d);
            Console.WriteLine("after swappning c= {0},d= {1}", c, d);

            Console.WriteLine();

            Employee e1 = new Employee(1, "shweta", "hr");
            Employee e2 = new Employee(3, "abc", "it");
            Console.WriteLine("before swappning e1({0}) \n e2({1})", e1.ToString(), e2.ToString());
            genericex.swap<Employee>(ref e1, ref e2);
            Console.WriteLine();
            Console.WriteLine("after swappning e1({0}) \n e2({1})", e1.ToString(), e2.ToString());
        }
    }
}
