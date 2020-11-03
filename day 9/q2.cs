using System;
using Personlibrary;

namespace day_9
{
    class q2
    {
        static void Main(string[] args)
        {
            Person[] p = new Person[3];
            p[0] = new programmer();
            p[1] = new dancer();
            p[2] = new singer();
            foreach (Person persons in p)
            {
                Console.WriteLine(persons.dojob());

                if (persons is programmer)
                    Console.WriteLine(((programmer)persons).testing());
            }
            ////----------------------------------------------
            //for (int i = 0; i < 3; i++)
            //   Console.WriteLine(p[i].dojob());
            //
            //--------------------------------------------------
            Console.WriteLine();
            programmer c = p[0] as programmer;
            Console.WriteLine(c.testing());
        }
    }

}
