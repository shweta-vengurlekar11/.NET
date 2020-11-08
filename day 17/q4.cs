using System;
using System.Threading;
using System.Threading.Tasks;

namespace day17
{
    class mythread
    {
        public Thread thrd;
        public mythread(string name, int num)
        {
            thrd = new Thread(this.fact);
            thrd.Name = name;
            thrd.Start(num);
        }
        public void fact(Object num)
        {
            Console.WriteLine("current thread is: {0}", Thread.CurrentThread.Name);
            int a,temp=1;
            a=(int)num;
            for (int i = 2; i <= a; i++)
            {
                temp *= i;
            }
            Console.WriteLine("factorial of {0} is {1}", a, temp);
        }
    }
    class q4
    {
        static void Main()
        {
            mythread m = new mythread("1st thread", 5);
            mythread m1 = new mythread("2nd thread", 10);
        }
    }
}
