using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accountlibrary
{
    public abstract class Account
    {
        readonly int id;
        String name;
        double balanceamt;
        static int getid = 0;
        protected const int minname = 15,minbal=1000;
        static Account() { Console.WriteLine("ICICI Bank"); }

        public Account(String nm,double bal)
        {
                id = ++getid;
                Name = nm;
                Balanceamt = bal;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length <= minname)
                    name = value;
                else
                    Console.WriteLine("name length can not be more that 25");
            }
        }
        public double Balanceamt
        {
            get;
            set;
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public void deposit(double amt)
        {
            if (amt > 0)
                balanceamt += amt;
            else
                Console.WriteLine("deposite amount should not be 0 or nagative");
        }
        public abstract void withdraw(double amt);

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Id,Name,Balanceamt);
        }
    }
    public class Saving : Account
    {
        public Saving(string nm, double bal)
            : base(nm, bal)
        {
        }
        public override void withdraw(double amt)
        {
            if ((Balanceamt - amt) < minbal)
                Console.WriteLine("Balance cannot be less than 1000" );
            else
            {
                Balanceamt = Balanceamt - amt;

            }

        }
        
    }
    public class Current : Account
    {
        public Current(string nm, double bal)
            : base(nm, bal)
        {
        }
        public override void withdraw(double amt)
        {
            if (amt > 0)
                Balanceamt -= amt;
            else
                Console.WriteLine("cant be withdrawn");
        }

    }
}

