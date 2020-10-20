//Accept marks of 5 students and print average of the marks.

using System;

namespace day_2
{
    class q8
    {
        static void Main(string[] args)
        {
            string a,b,c,d,e;
            int p,q,r,s,t,avg=0;
            bool status;
            Console.WriteLine("enter marks of 5 students");
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            d = Console.ReadLine();
            e = Console.ReadLine();
            // b = float.Parse(a);
            p = Convert.ToInt32(a);
            q = Convert.ToInt32(b);
            r = Convert.ToInt32(c);
            s = Int32.Parse(d);
            status = Int32.TryParse(e,out t);
            if (status == true)
            {
                avg = (p + q + r + s + t) / 5;
                Console.WriteLine("average of marks is :{0}", avg);
            }
        }

    }
}

