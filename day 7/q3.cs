//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace day_7
//{
//    class q3
//    {
//        static void Main(string[] args)
//        {
//            char no;
//            char[] arr = new char[5];
//            char[] cpy = new char[5];
//            Console.WriteLine("enter 5 characters");
//            for (int i = 0; i < 5; i++)
//            {
//                no = char.Parse(Console.ReadLine());
//                arr[i] = no;
//            }
//            arr.CopyTo(cpy, 0);
            

//            Console.WriteLine("array in discending order");
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine(cpy[i]);
//            }
//        }
//    }
//}