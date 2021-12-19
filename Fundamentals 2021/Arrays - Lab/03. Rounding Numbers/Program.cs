﻿using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            for(int i = 0; i<numbers.Length; i++)
            {
                Console.WriteLine("{0} => {1}",Convert.ToDecimal(numbers[i]),Convert.ToDecimal(Math.Round(numbers[i], MidpointRounding.AwayFromZero)));
            }

        }
    }
}
