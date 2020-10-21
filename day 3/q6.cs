//Create a class having instance member salary. Create a object of a class. 
//Print data type of reference of a class also print parent class name.

using System;

namespace day_3
{
    class employee
    {
        public double salary;
    }
    class q6
    {
        static void Main()
        {
            employee e = new employee();
            Console.WriteLine(e.GetType());
            Console.WriteLine(e.GetType().BaseType);
        }
    }
}
