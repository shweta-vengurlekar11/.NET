//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////Write a generic delegate which will point to method which will return square , cube ,and factorial of a number

//delegate void numeric<T>(T a);
//namespace day14
//{
//    class calculation
//    {
//        public static void sqr(int a)
//        {
//            Console.WriteLine("sqr is {0}", a * a);
//        }
//        public static void cube(double a)
//        {
//            Console.WriteLine("cube is {0}", a * a*a);
//        }
//        public static void fact(int a)
//        {
//            int temp=1;
//            for (int i = 2; i <= a; i++)
//            {
//                temp *= i;
//            }
//            Console.WriteLine("fact of number is {0}", temp);
//        }
//    }
//    class q3
//    {

//        static void Main(string[] args)
//        {
//            numeric<int> nm = new numeric<int>(calculation.sqr);
//            nm(20);
//            numeric<double> nm1 = new numeric<double>(calculation.cube);
//            nm1(25.5);
//            numeric<int> nm2 = new numeric<int>(calculation.fact);
//            nm2(3);

//        }
//    }
//}
