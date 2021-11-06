using System;
using System.Linq;

namespace _4._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] password = Console.ReadLine().ToCharArray();

            if(passLength(password) && passConsists(password) && atleastTwoNumbers(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!passLength(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!passConsists(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!atleastTwoNumbers(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

            }

        }
        
        static bool passLength(char[] password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else return false;
        }

        static bool passConsists(char[] password)
        {
            bool isLetterOrNumer = false;
            for(int i = 0; i < password.Length; i++)
            {
                if (((int)password[i] > 47 && (int)password[i] < 58) || ((int)password[i] > 64 && (int)password[i] < 91) || ((int)password[i] > 96 && (int)password[i] < 123))
                    isLetterOrNumer = true;
                else
                {
                    isLetterOrNumer = false;
                    break;
                }
            }

            return isLetterOrNumer;
        }

        static bool atleastTwoNumbers(char[] password)
        {
            int count = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (((int)password[i] > 47 && (int)password[i] < 58))
                    count++;
            }

            if (count >= 2) return true;
            else return false;

        }
    }
}
