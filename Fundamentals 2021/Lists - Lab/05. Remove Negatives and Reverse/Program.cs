using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> negativeNumbers = new List<int> { };
            //numbers.RemoveAll(x => x < 0);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    negativeNumbers.Add(numbers[i]);
                }
            }

            foreach (int item in negativeNumbers)
            {
                numbers.Remove(item);
            }

            if (numbers.Count > 0)
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}
