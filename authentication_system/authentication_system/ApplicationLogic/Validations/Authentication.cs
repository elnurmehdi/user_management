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
    }

}
