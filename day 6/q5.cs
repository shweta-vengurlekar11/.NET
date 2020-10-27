//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace day_6
//{
//    class q5
//    {
//        static void Main(string[] args)
//        {
//            int[,] arr = new int[3, 3];
//            int num, sum = 0;
//            Console.WriteLine("enter data");
//            for (int r = 0; r < 3; r++)
//            {
//                for (int c = 0; c < 3; c++)
//                {
//                    num = Int32.Parse(Console.ReadLine());
//                    arr[r, c] = num;
//                }
//            }
//            for (int r = 0; r < 3; r++)
//            {
//                for (int c = 0; c < 3; c++)
//                {
//                    sum = sum + arr[r, c];
//                }
//            }
//            Console.WriteLine("average is {0}", sum / 9);
//        }
//    }
//}
