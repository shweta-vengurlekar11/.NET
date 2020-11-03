using System;
delegate void bonus(string nm, double sal);
namespace day11
{
    abstract class Employee
    {
        public event bonus bonusevent;
        int id;
        String name;
        double salary;
        static int getid = 0;
        public Employee(string nm, double sal)
        {
            id = ++getid;
            Name = nm;
            Salary = sal;
        }
        public string Name
        {
            get;
            set;
        }
        public double Salary
        {
            get;
            set;
        }
        public void Onbonus(string name, double Salary)
        {
            if (bonusevent != null)
                bonusevent(name, Salary);
        }

        public abstract void givebonus();
    }
    class Permenent : Employee
    {
        public Permenent(string nm, double sal) : base(nm, sal)
        {
        }
        public override void givebonus()
        {
            Console.WriteLine("giving bonus to permemnt employee");
            Onbonus(Name, Salary);
        }

    }
    class Temporary : Employee
    {
        public Temporary(string nm, double sal) : base(nm, sal)
        {
        }
        public override void givebonus()
        {
            Console.WriteLine("giving bonus to Temporary employee");
            Onbonus(Name, Salary);
        }

    }
    class Message
    {
        public void mesg(string name, double Balance)
        {
            Console.WriteLine("name :{0} , Salary:{1}", name, Balance);
        }
    }

    class q3
    {
        static void Main(string[] args)
        {
            Message m = new Message();
            Employee[] e = new Employee[4];
            e[0] = new Permenent("abc", 23000);
            e[1] = new Permenent("pqr", 21000);
            e[2] = new Temporary("abc1", 2000);
            e[3] = new Temporary("pqr2", 1000);

            for (int i = 0; i < e.Length; i++)
            {
                e[i].bonusevent += m.mesg;
            }

            e[1].givebonus();
            e[2].givebonus();

        }
    }
}
