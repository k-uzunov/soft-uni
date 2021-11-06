using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());

            double division = factoriel(a) / factoriel(b);

            Console.WriteLine($"{division:F2}");

        }
        static double factoriel(double a)
        {
            double fact = 1;
            for(int i = 1; i <= a; i++)
            {
                fact *= i; 
            }

            return fact;
        }
    }
}
