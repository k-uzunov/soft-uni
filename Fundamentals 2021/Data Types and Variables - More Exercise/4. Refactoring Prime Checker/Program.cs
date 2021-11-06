using System;

namespace _4._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeEnd = int.Parse(Console.ReadLine());
            for (int number = 2; number <= rangeEnd; number++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor < number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", number, isPrime.ToString().ToLower());
            }

        }
    }
}
