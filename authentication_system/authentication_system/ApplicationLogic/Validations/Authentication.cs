using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace authentication_system.ApplicationLogic.Validations
{
    class Authentication
    {
        public static void Register()
        {


        }



        public static string GetName()
        {
            Console.Write("Please, enter user's name: ");
            string name = Console.ReadLine();

            while (!Validation.IsValidName(name))
            {
                Console.Write("Please, enter correct user name: ");
                name = Console.ReadLine();
            }
            return name;
        }

        public static string GetSurname()
        {
            Console.Write("Please, enter user's surname: ");
            string surname = Console.ReadLine();

            while (!Validation.IsValidSurname(surname))
            {
                Console.Write("Please, enter correct user surname: ");
                surname = Console.ReadLine();
            }
            return surname;

        }


        public static string GetEmail()
        {
            Console.Write("Please, enter user's email: ");
            string email = Console.ReadLine();

            while (!Validation.IsValidEmail(email))
            {
                Console.Write("Please, enter correct user email: ");
                email = Console.ReadLine();
            }
            return email;

        }

        public static string GetPassword()
        {
            Console.Write("Please, enter user's password: ");
            string password = Console.ReadLine();
            while (!Validation.IsValidPassword(password))
            {
                Console.Write("Please, enter correct user password: ");
                password = Console.ReadLine();
            }
            Console.Write("Please, enter password again: ");
            string confirmPassword = Console.ReadLine();
            while (!Validation.IsPasswordConfirm(password, confirmPassword))
            {
                Console.Write("Please, enter correct confirm password: ");
                confirmPassword = Console.ReadLine();
            }
            return password;

        }
    }

}
