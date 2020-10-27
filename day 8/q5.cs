using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_8
{
    class Animal
    {
        public virtual string speak()
        {
            return "I don’t know how to speak";
        }
    }
    class Dog : Animal
    {
        public override string speak()
        {
            return "bhow bhow";
        }
    }
    class cat : Animal
    {
        public override string speak()
        {
            return "meow meow";
        }
    }
    class showpoly
    {
        public static void perform(Animal a)
         {
              Console.WriteLine(a.speak());
          }
        static void Main()
        {
            perform(new Animal());
            perform(new Dog());
            perform(new cat());
        }

    }
}
