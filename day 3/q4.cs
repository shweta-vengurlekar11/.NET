//Create class library “mycaculator” having instance method  add and product which will return sum and product of two number.  
//Create shared assembly and use in your project. After  this add method cube  
//to a copy of class library “mycaculator” change the version and add it to GAC. Create a application to use this new version of library.
//Ensure that your both console application works.

using System;
using mycalculator;

namespace day_3
{
    class q4
    {
        static void Main()
        {
            mycalculatorclass m = new mycalculatorclass();
            Console.WriteLine("adddition is "+m.add(2, 3));
            Console.WriteLine("product is " + m.product(2, 3));
            Console.WriteLine("cube is " + m.cube(5));
        }
    }
}
