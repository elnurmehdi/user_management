using System;

namespace authentication_system
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/exit");



            while (true)
            {


                Console.WriteLine();
                Console.WriteLine("Please, enter one of shown commands:");
                string command = Console.ReadLine();

                if (command == "/register")
                {
                   
                }
                else if (command == "/login")
                {
                    

                }
                else if (command == "/exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Command not found!");
                }
            }
        }
    }
}
