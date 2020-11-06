using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day16
{
    class myclass
    {
        public Thread t;
        public myclass(string thrdname)
        {
            t = new Thread(this.print);
            t.Name = thrdname;
            t.Start();
        }
        public void print()
        {
            Console.WriteLine("currently working {0}", Thread.CurrentThread.Name);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}", i);
                Thread.Sleep(1000);
            }
        }
    }
    class q2
    {
        static void Main()
        {
            myclass m = new myclass("first thread");
            myclass m2 = new myclass("second thread");
            m2.t.Join();

            //MessageBox.Show("I'm busy!", "Work on main thread...");

        }
    }
}
