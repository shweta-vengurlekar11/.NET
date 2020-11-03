using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personlibrary
{
    public class Person
    {
        public virtual string  dojob()
        {
            return "doing job";
        }
    }
    public class programmer : Person
    {
        public override string  dojob()
        {
            return "doing coding";
        }
        public string testing()
        {
            return "I am testing code also";
        }
    }
    public class singer : Person
    {
        public override string dojob()
        {
            return "doing singing";
        }
    }
    public class dancer: Person
    {
        public override string dojob()
        {
            return "doing dancing";
        }
    }
}
