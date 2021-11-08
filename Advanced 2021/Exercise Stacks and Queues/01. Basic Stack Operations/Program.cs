using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int> { };
            int[] commands = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int elementsToPush = commands[0];
            int elementsToPop = commands[1];
            int elemntToSeek = commands[2];

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < elementsToPush; i++)
            {
                numbers.Push(input[i]);    
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                numbers.Pop();
            }

            if (numbers.Contains(elemntToSeek))
            {
                Console.WriteLine("true");
            }else if (numbers.Count > 0)
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
