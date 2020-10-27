//using System;
//using accountlibrary;

//namespace day_6
//{
//    class q1_1
//    {
//        static void Main()
//        {
//            Account a = null;
//            try
//            {
//                a = new Account("shweta",1000);
//                Account.payint(a);
//                a.withdraw(100);
//               Console.WriteLine("current balnce is {0} ",a.Balance);
//                Console.WriteLine(a.display());
//            }
//            catch
//            {
//                Console.WriteLine("balance less than 1000 rs not allowed"); 
//            }
//           // a.deposit(-2);
//            Account a2 = new Account("pooja", 20000);
//            a2.deposit(500);
//            Console.WriteLine(a2.display());
//        }
//    }
//}
