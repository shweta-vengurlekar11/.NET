//Accept a number from user and display its type and parent class.
using System;
namespace day_3
{
    class q5
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("enter a nnumber");
            a = Console.ReadLine();
            int num = Int32.Parse(a);
            var number = num;
            Console.WriteLine("datatype of number is :" + number.GetType());
            Console.WriteLine("basetype of number is :" + number.GetType().BaseType);
        }
    }
}
