using System;

namespace _4._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = start; start <= end; start++)
            {
                sum += start;
                Console.Write($"{start} ");
            }

            Console.WriteLine("\nSum: {0}", sum);
        }
    }
}
