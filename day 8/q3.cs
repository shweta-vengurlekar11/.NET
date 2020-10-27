//using System;

//namespace day_8
//{
//    class outdemo
//    {
//        public int[] sqrarray(int[] arr, out int sum)
//        {
//            int num = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                num += arr[i];
//                arr[i] = arr[i] * arr[i];
//            }
//            sum = num;
//            return arr;
//        }
//    }
//    class q3
//    {
//        static void Main()
//        {
//            int sum; int[] sum1;
//            outdemo o = new outdemo();
//            int[] arr = new int[] { 2, 6, 25, 5 };
//            sum1=o.sqrarray(arr, out sum);
//            Console.WriteLine("sum is:{0}", sum);
//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.WriteLine(sum1[i]);
//            }

//        }
//    }
//}
