using System;
using System.Linq;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Join("", username.Reverse());
            
            for(int i = 1; i<=4; i++)
            {
                string passInput = Console.ReadLine();
                if (password == passInput)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                } else
                {
                    if (i == 4) Console.WriteLine($"User {username} blocked!");
                    Console.WriteLine("Incorrect password. Try again.");
                   
                }
            }
        }
    }
}
