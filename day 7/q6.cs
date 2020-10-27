using System;
//Accept a name from user accept password and confirm password from user if
//password and confirm password string are same give message valid data else print invalid data.

namespace day_7
{
    class q6
    {
        public static void passwordcheck()
        {
            Console.WriteLine("enter password");
            string password = Console.ReadLine();

            Console.WriteLine("confirm password");
            string c_password = Console.ReadLine();

            if (password.Equals(c_password))
            {
                Console.WriteLine("passwords matched");
            }
            else
            {
                Console.WriteLine("passwords are not matching");
                Console.WriteLine();
                q6.passwordcheck();
            }
        }
        static void Main()
        {
            Console.WriteLine("enter Name");
            string name = Console.ReadLine();
            q6.passwordcheck();
            
        }
    }
}
