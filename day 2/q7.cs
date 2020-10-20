// Accept a number and stored it in byte data type if it goes beyond range throw exception

using System;

namespace day_2
{
    class q7
    {
        static void Main(string[] args)
        {
            string a;
            byte b; int x;
            bool status;
            Console.WriteLine("enter number");
            a = Console.ReadLine();
            status = Int32.TryParse(a, out x);

            if (status == true)
            {

                checked
                {
                    b = (byte)x;
                    Console.WriteLine("byte number is :{0}", b);
                }
            }
        }

    }
}

