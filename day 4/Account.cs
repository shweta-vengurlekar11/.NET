using System;
namespace accountlibrary
{
    public class Account
    {
        static int getid;
        int id;
        string name;
        double balance;
        const int maxcapacity = 3;
        static Account()
        {
            Console.WriteLine("welcome to ICICI Bank");
        }
        public Account(string nme, double bal)
        {
            if (getid < maxcapacity)
            {
                id = ++getid;
                name = nme;
                balance = bal;
            }
            else
                Console.WriteLine("capacity is full,can not open account");
        }
        public void deposit(double amt)
        {
            balance += amt;
        }
        public void withdraw(double amt)
        {
            balance -= amt;
        }
        public string display()
        {
            return string.Format("{0}{1}{2}", id, name, balance);
        }
    }
}