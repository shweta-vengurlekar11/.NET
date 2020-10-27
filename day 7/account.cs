﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accountlibrary_day7
{
    public class Account
    {
        private int _id;
        private String _name;
        private double _balance;
        static int getid = 0;
        const int minbal = 1000;
        static Account()
        {
            Console.WriteLine("Welcome to ICICI Bank");
        }
        public Account(string nm, double bal)
        {
            if (bal >= minbal)
            {
                _id = ++getid;
                _name = nm;
                _balance = bal;
            }
            else
            {
                throw new Exception("balance cant be less than 1000 rs");
            }
        }
        public string Name
        {
            get;
            set;
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < minbal)
                    throw new Exception("balance cant be less than 1000rs");
                _balance = value;
            }
        }
        public void deposit(double amt)
        {
            if (amt <= 0)
                throw new Exception("value cant be 0 or negative");
            _balance += amt;
        }
        public void withdraw(double amt)
        {
            if (amt <= 0)
                throw new Exception("value cant be 0 or negative");
            if (_balance < minbal)
                Console.WriteLine("balance cant be less than 1000");
            else
                _balance -= amt;
        }
        public String display()
        {
            return string.Format("{0} {1} {2}", _id, _name, _balance);
        }
    }
}
