using System;
using System.Linq;

namespace _6._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for(int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0, rightSum = 0;
                if (i == 0)
                {
                    leftSum = 0;
                }
                else
                {
                    for (int left = i - 1; left >= 0; left--)
                    {
                        leftSum += numbers[left];
                    }
                }

                if (i == numbers.Length - 1)
                {
                    rightSum = 0;

                    if (leftSum != rightSum)
                    {
                        Console.WriteLine("no");
                    }
                }
                else
                {
                    for(int right = i+1; right < numbers.Length; right++)
                    {
                        rightSum += numbers[right];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    break;
                }

            }

        }
    }
}
