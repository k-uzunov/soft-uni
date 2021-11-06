using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if (topNumber(i)) Console.WriteLine(i); ;
            }
        }

        static bool topNumber(int number)
        {
            bool oddDigit = false;
            int digit, sum = 0;
            while (number > 0)
            {
                digit = number % 10;
                sum += digit;
                if (digit % 2 != 0) oddDigit = true;
                number /= 10;
            }

            if (sum % 8 == 0 && oddDigit) return true;
            else return false;
        }
    }
}
