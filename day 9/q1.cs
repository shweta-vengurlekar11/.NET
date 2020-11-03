using System;
using accountlibrary;

namespace day_9
{
    class q1
    {
        static void Main()
        {
            Account[] a = new Account[3];
            a[0] = new Saving("shweta vengurlekar", 23000);
            a[1] = new Current("sh", 20000);
            a[2] = new Saving("shw", 1000);

            foreach (Account accounts in a)
                accounts.withdraw(100);

            foreach (Account accounts in a)
                Console.WriteLine(accounts.ToString());
        }

    }
}
