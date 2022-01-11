using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            //first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.

            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            Console.WriteLine(string.Join(" ", Gauss(numbers)));
        }

        static List<double> Gauss(List<double> numbers)
        {
            List<double> gaussTrick = new List<double> { };
            int lastIndex = numbers.Count - 1;
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                gaussTrick.Add(numbers[i] + numbers[lastIndex - i]);
            }
            if (numbers.Count % 2 == 1)
            {
                gaussTrick.Add(numbers[numbers.Count / 2]);
            }
            return gaussTrick;
        }
    }
}
