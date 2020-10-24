using System;

namespace q1library
{
    public class Account
    {
        private int id;
        private string name;
        private double balanceamt;
        public Account(int aid, string aname, double abalance)
        {
            id = aid;
            name = aname;
            balanceamt = abalance;
        }
        public void deposite(int amt)
        {
            balanceamt += amt;
        }
        public void withdraw(int amt)
        {
            balanceamt -= amt;
        }
        public string dsiplay()
        {
            return String.Format("{0} {1}", name, balanceamt);
        }
    }
}
