﻿using System;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (numbers.Length > 1)
            {
                int[] condensed = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }

                numbers = new int[condensed.Length];
                numbers = condensed;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
