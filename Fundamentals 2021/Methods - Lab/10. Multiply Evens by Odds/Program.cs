using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvensAndOdds(GetSumOfEvenDigits(Math.Abs(number)), GetSumOfOddDigits(Math.Abs(number)));
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            for (int i = number; i > 0; i/=10)
            {
                int digit = i % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }

            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            for (int i = number; i > 0; i /= 10)
            {
                int digit = i % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
            }

            return sum;
        }

        static int GetMultipleOfEvensAndOdds(int sumOfEvens, int sumOfOdds)
        {
            return sumOfEvens * sumOfOdds;
        }
    }
}
