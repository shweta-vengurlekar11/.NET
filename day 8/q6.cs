//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace day_8
//{
//    class mymath
//    {
//        public double sqr(params double[] arr)
//        {
//            double num = 0, avg;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                num = num + arr[i];
//            }
//            avg = num / arr.Length;
//            return avg;
//        }
//    }
//    class q6
//    {
//        static void Main()
//        {
//            double avg;
//            mymath m = new mymath();
//            avg = m.sqr(4, 7, 8, 7);
//            Console.WriteLine("avg of a number is={0}", avg);
//            avg = m.sqr(2, 3);
//            Console.WriteLine("avg of a number is={0}", avg);
            
//        }
//    }
//}
