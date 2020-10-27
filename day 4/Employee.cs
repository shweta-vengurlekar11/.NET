using System;
//Create a class Employee having member variable Firstname, Lastname,
//Middlename.let your application create object even if user does not enter Middlename. 
//Create two constructor one take parameter for Firstname,
//Lastname and second constructor which will take all the parameter. 

namespace emplibraryq1
{
    public class Employee
    {
        String firstname, lastname, middlename;
       static Employee()
        {
            Console.WriteLine("welcome to Visual IT");
        }
        public Employee(String fname, string lname)
        {
            firstname = fname;
            lastname = lname;
        }
        public Employee(String fname, string lname,string mname)
        {
            firstname = fname;
            lastname = lname;
            middlename = mname;
        }
        public string display()
        {
            return string.Format("{0} {1} {2}", firstname, middlename, lastname);
        }
    }
}
