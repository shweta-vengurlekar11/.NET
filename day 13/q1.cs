using System;
using System.Collections.Generic;
using System.Text;

namespace day_13
{
    public class Account
    {
        readonly int id;
        String name;
        double balanceamt;
        static int getid = 0;
        protected const int minname = 15, minbal = 1000;
        static Account() { Console.WriteLine("ICICI Bank"); }

        public Account(String nm, double bal)
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
                    throw new Exception("name length can not be more that 25");
            }
        }
        public double Balanceamt
        {
            get
            { return balanceamt; }
            set
            {
                if (value <= 0)
                    throw new Exception("balance amount can not be less than or equal to zero");
                else
                    balanceamt = value;
            }
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
                throw new Exception("deposite amount should not be 0 or nagative");
        }
        public void withdraw(double amt)
        {
            if ((balanceamt-amt) < 1000)
            {
                throw new Exception("insuffiecient balance");
            }
            else
                balanceamt -= amt;

        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Id, Name, Balanceamt);
        }
    }
    class q1
    {
        static void Main()
        {
            Account a = new Account("shweta", 20000);
            //Account a1 = new Account("shweta vengurlekar", 20000);

            //a.Balanceamt=-36666;
            //a.withdraw(19500);
            Console.WriteLine(a.ToString());
        }
    }
}
