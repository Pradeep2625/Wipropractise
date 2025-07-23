using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prog3
    {
        void simpleLoginForm(string username,string password)
        {
            if (username == "admin" && password == "password123")
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }
       
        static void Main(string[] args)
        {
            string username, password;
            Prog3 prog3 = new Prog3();
            Console.WriteLine("Enter username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            password = Console.ReadLine();
            prog3.simpleLoginForm(username, password);

        }
    }
}
