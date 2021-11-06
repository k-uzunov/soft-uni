using System;

namespace _3._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            const double eps = 0.000001;

            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            double difference = Math.Abs(numberA - numberB);

            if (difference >= eps)
            {
                Console.WriteLine("False");
            }else
            {
                Console.WriteLine("True");
            }
        }
    }
}
