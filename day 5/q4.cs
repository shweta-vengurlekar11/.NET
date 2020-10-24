using System;
using q4library;

namespace day_4
{
    class q4
    {
        static void Main()
        {
            printer ob = printer.getobj();

            Console.WriteLine(ob.display());
            printer ob1 = printer.getobj();

            Console.WriteLine(ob1.display());

        }
    }
}
