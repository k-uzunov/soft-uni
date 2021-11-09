using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int> { };
            int numberOfQueries = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < numberOfQueries; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                switch (input[0])
                {
                    case 1:
                        stack.Push(input[1]);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        if(stack.Count>0)
                            Console.WriteLine(stack.Max());
                        break;
                    case 4:
                        if (stack.Count > 0)
                            Console.WriteLine(stack.Min());
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
