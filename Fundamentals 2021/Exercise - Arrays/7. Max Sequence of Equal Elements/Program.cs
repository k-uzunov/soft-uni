using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int currentSequence = 1;
            int startIndex = 0;
            int offset = 0;
            int maxSequence = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(i == numbers.Length - 1)
                {
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        offset = startIndex;

                    }
                    break;
                }
                if(numbers[i] != numbers[i + 1])
                {
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        offset = startIndex;
                        currentSequence = 1;
                        startIndex = i + 1;
                    }
                    else
                    {
                        currentSequence = 1;
                        startIndex = i + 1;
                    }
                }
                else
                {
                    currentSequence++;
                }
            }

            for(int i = 0; i<maxSequence; i++)
            {
                Console.Write(numbers[i+offset] + " ");
            }
        }
    }
}
