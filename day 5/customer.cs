using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3library
{
    public class customer
    {
        int id,getid=0;
        string name;
        double billamount;
        //public customer(string name, double billamount)
        //{
        //    this.billamount = billamount;
        //    this.name = name;
        //    id = ++getid;
        //}
        public String display()
        {
            return string.Format("{0} {1} {2}",id,name,billamount);
        }
    }

}
