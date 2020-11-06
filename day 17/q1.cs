using System;
using System.Data.SqlClient;

namespace ADO01_ConsoleApplication
{
    public class Employee
    {
        public void details()
        {

            string connectionString = @"Data Source=(localdb)\Projects;Initial Catalog=Empdata;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))//Idesposable class written inside 
            //using block
            {

                SqlCommand cmd = new SqlCommand("Select * from Emp", con);

                con.Open();
                Console.WriteLine("connected");
                SqlDataReader rdr = cmd.ExecuteReader(); //returns object of sqldatareder
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {

                        Console.WriteLine("{0} {1} {2}", rdr["Id"], rdr["Name"], rdr["Salary"]);
                    }
                }
            }

        }
    }
    class Program
    {
        static void Main()
        {
            Employee obj = new Employee();
            obj.details();
        }

    }
}
