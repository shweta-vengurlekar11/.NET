using System;
//. Create a class calculator having  static method square, cube, absolute, floor,ceil who’s job is to find square, cube, 
//absolute (2.2 ==2)floor(eg. 2.7==O/P==2) , Ceil(eg 2.9==3) value respectively.

namespace q5library
{
    public class calculator
    {
        public static float square(float n)
        {
            return n * n;
        }

        public static float cube(float n)
        {
            return n * n * n;
        }

        public static float absolute(float n)
        {
            return Math.Abs(n);
        }

        public static float floor(float n) 
        { 
            return (float)Math.Floor(n); 
        }

        public static float ceil(float n)
        { 
            return (float)Math.Ceiling(n); 
        }
    }
}
