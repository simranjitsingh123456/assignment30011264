/*
 Name = Simranjit Singh
 Student ID = 30011264
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string username = null;
            string password = null;
            string confirmPassword = null;

            
            do
            {
                /*
                 * Welcome message for the user
                 */
                Console.WriteLine("*************************************");
                Console.WriteLine("*       LOGIN SYSTEM       *");
                Console.WriteLine("*************************************");
              
                Console.Write("Enter username: ");
                username = Console.ReadLine();
                Console.Write("Enter password: ");
                password = Console.ReadLine();
                Console.Write("Re-enter password: ");
                confirmPassword = Console.ReadLine();

                if (validateUsername(username))
                {
                    if (validatePassword(password, confirmPassword))
                    {
                        Console.WriteLine("Username and Password have been accepted and set. ");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Re-try! Password shoud be eight characters long and should match as well.");
                    }
                }
                else
                {
                    Console.WriteLine("Re-try! Username must be eight characters long!");
                }
                count ++;
                Console.WriteLine();
            } while (count <= 1);

            Console.ReadKey();
        }

        /*
         * Method to validate the username
         */
        static bool validateUsername(string value)
        {
            if (value.Length >= 8)
                return true;
            return false;
        }

        
        static bool validatePassword(string password, string confirmPassoword)
        {
            if(password.Equals(confirmPassoword))
            {
                if (password.Length >= 8)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
