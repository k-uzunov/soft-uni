using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                int number = i;
                int sumOfDigits = 0;
                bool isSpecial = false;

                while(number > 0)
                {
                    sumOfDigits += number % 10;
                    number /= 10;
                }
                
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11) isSpecial = true;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
