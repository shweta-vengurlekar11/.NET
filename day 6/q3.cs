//using System;
////Accept data in an array and print sum  also store square of each element in new array.

//namespace day_6
//{
//    class q3
//    {
//        static void Main(string[] args)
//        {
//            int[,] arr = new int[3, 3];
//            int[,] arrsqr = new int[3, 3];
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
//                    num = arr[r, c];
//                    arrsqr[r, c] = num*num;
//                }
//            }
//            Console.WriteLine("sum of array data is {0}",sum);
//            for (int r = 0; r < 3; r++)
//            {
//                for (int c = 0; c < 3; c++)
//                {
//                    Console.Write(arrsqr[r, c]+" ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
