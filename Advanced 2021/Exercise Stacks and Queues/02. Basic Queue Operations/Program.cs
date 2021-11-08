using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>{ };
            int[] commands = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int elementsToEnqueue = commands[0];
            int elementsToDequeue = commands[1];
            int elemntToSeek = commands[2];

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < elementsToEnqueue; i++)
            {
                numbers.Enqueue(input[i]);
            }

            for (int i = 0; i < elementsToDequeue; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(elemntToSeek))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
