using System;
using System.Linq;

namespace _9._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                char[] number = command.ToCharArray();
                Console.WriteLine(palindrome(number));
                command = Console.ReadLine();
            }
            


        }

        static bool palindrome(char[] number)
        {
            char[] reversednumber = new char[number.Length];
            Array.Copy(number, 0, reversednumber, 0, number.Length);
            Array.Reverse(reversednumber);
            bool isPalindrome = true;
            for(int i = 0; i < number.Length; i++)
            {
                if (reversednumber[i] != number[i]) isPalindrome = false;
            }

            return isPalindrome;
        }
    }
}
