//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace day_6
//{
//    class jaggedarray
//    {
//        static void Main()
//        {
//            int r, c,n=0;
//            Console.WriteLine("enter number of rows");
//            r = Int32.Parse(Console.ReadLine());
//            int[][] jagged = new int[r][];
//            Console.WriteLine("enter number of columns for {0} rows",r);
//            for (int i = 0; i < r; i++)
//            {
//                c = Int32.Parse(Console.ReadLine());
//                jagged[i] = new int[c];
//            }
//            for (int i = 0; i < jagged.Length; i++)
//            {
//                for (int j = 0; j < jagged[i].Length; j++)
//                {
//                    jagged[i][j]=++n;
//                }
//            }
//            for (int i = 0; i < jagged.Length; i++)
//            {
//                for (int j = 0; j < jagged[i].Length; j++)
//                {
//                    Console.Write(jagged[i][j]+" ");
//                }
//                Console.WriteLine();
//            }
//        }

//    }
//}
