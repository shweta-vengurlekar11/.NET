//Accept a number from user and pass it to static method of a struct calculator it should print all factor of a number.
using System;
namespace day_3
{
    struct calculator
    {
        public static void factor(int no)
        {
            Console.WriteLine("factors are :");
            for (int i = 1; i <= no; i++)
            {
                if (no % i == 0)
                    Console.WriteLine(i + " ");
            }
        }
    }
    class q2
    {
        static void Main(string[] args)
        {
            string no;
            Console.WriteLine("enter a number");
            no = Console.ReadLine();
            int num = Int32.Parse(no);
            calculator.factor(num);

        }
    }
}
