using System;
using System.IO;

namespace day_13
{
    public class student
    {
        int id; string name; double marks;
        static int getid = 0;
        public student(string nm, double mks)
        {
            id = ++getid;
            Name = nm;
            Marks = mks;
        }
        public string Name
        {
            get; set;
        }
        public double Marks
        {
            get; set;
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public void give_gracemarks(int mks)
        {
            if (mks > 5)
            {
                throw new myexception("Grace Marks more than 5 is not allowed");
            }
            marks += mks;
        }
    }
    class myexception : ApplicationException
    {
        public string msg;
        public myexception(string msg)
        {
            this.msg = msg;
        }
    }
    class q2
    {
        static void Main(string[] args)
        {
            string str = null;
            FileStream fout = null;
            StreamWriter fstr_out = null;

            try
            {
                student s1 = new student("shweta", 10);
                student s2 = new student("abs", 34);
                s1.give_gracemarks(15);

                fout = new FileStream("test.txt", FileMode.Create, FileAccess.Write);
                fstr_out = new StreamWriter(fout);

                str = s1.Id + " " + s1.Name + " " + s1.Marks;
                fstr_out.Write(str);
            }
            catch (myexception e)
            {
                Console.WriteLine("{0}", e.msg);
            }
            catch (Exception e1)
            {
                Console.WriteLine("{0}", e1.Message);
            }
            finally
            {
                fstr_out.Close();
            }

        }
    }
}
