using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to new Login System");

            //Asking a user to enter a username
            Console.Write("\nEnter Username: ");
            string username = Console.ReadLine();

            //Here i"m checking a username if it is correct or not
            while (CheckUsername(username) == 0)
            {
                Console.WriteLine("Username does not meet the correct criteria. Try Again.");
                Console.Write("\nEnter Username: ");
                username = Console.ReadLine();
            }

            //Asking a user to enter the password
            Console.Write("\nEnter Password: ");
            string password = Console.ReadLine();
            Console.Write("Repeat Password: ");
            string repeatPassword = Console.ReadLine();

            //Here i"m checking a password if it is correct or not

            while (CheckPassword(password, repeatPassword) == 0)
            {
                Console.WriteLine("Passwords does not meet the correct criteria. Try Again.");
                Console.Write("\nEnter Password: ");
                password = Console.ReadLine();
                Console.Write("Repeat Password: ");
                repeatPassword = Console.ReadLine();
            }

            Console.WriteLine("\nUsername and Password have been accepted and set.");
            Console.ReadLine();

        }

        //method to check the lenght of the username
        static int CheckUsername(string s)
        {
            //measuiring the length of username
            int length = s.Length;

            if (length >= 8)
            {
                return 1;
                //returning 1 if correct
            }
            else
            {
                return 0;
                //returning 0 if not correctt.
            }
        }

        //method to check criteria for passwords
        static int CheckPassword(string s, string r)
        {
            //storing length of passwords
            int sLength = s.Length;
            int rLength = r.Length;

            //checking for length of passwords and 
            //if they are same
            if (sLength >= 8 && rLength >= 8 && s == r)
            {
                return 1;
                //returning 1 if correct
            }
            else
            {
                return 0;
                //returning 0 if not correct.
            }
        }
    }
}