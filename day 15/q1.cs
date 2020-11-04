using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_15
{
    class Student
    {
        int rollno; String name; int total;
        static int getrollno = 0;
        public Student(String name, int maths, int sci, int eng)
        {
            rollno = ++getrollno;
            Name = name;
            total = sci + maths + eng;

        }
        public string Name
        {
            get;
            set;
        }
        public int Total
        {
            get
            {
                return total;
            }
        }
        public int Rollno
        {
            get
            {
                return rollno;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Rollno, Name, Total);
        }
    }
    class q1
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("shweta", 12, 13, 14);
            Student s2 = new Student("raj", 18, 25, 14);
            Student s3 = new Student("abc", 12, 13, 14);
            Student s4 = new Student("xyz", 12, 13, 14);
            Student s5 = new Student("lmn", 12, 13, 14);

            SortedList<string, Student> sl = new SortedList<string, Student>();
            sl.Add(s1.Name, s1);
            sl.Add(s2.Name, s2);
            sl.Add(s3.Name, s3);
            sl.Add(s4.Name, s4);
            sl.Add(s5.Name, s5);

            foreach (KeyValuePair<string, Student> sl1 in sl)
                Console.WriteLine(sl1);

        }
    }
}
