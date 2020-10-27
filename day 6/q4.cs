//using System;
////Accept data in an array and print sum  also store square of each element in new array.

//namespace day_6
//{
//    class q4
//    {
//        static int cube(int a)
//        {
//            return a * a*a;
//        }
//        static void Main(string[] args)
//        {
//            int[,] arr = new int[3, 3];
//            int num;

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
//                    arr[r, c] = cube(arr[r, c]);
//                }
//            }
//            for (int r = 0; r < 3; r++)
//            {
//                for (int c = 0; c < 3; c++)
//                {
//                    Console.Write(arr[r, c] + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
