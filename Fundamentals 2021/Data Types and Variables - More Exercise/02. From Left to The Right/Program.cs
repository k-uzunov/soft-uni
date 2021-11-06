using System;
using System.Linq;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                BigInteger[] numbers = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
                BigInteger num = 0;
                int sum = 0;
                if (numbers[0] > numbers[1])
                    num = numbers[0];
                else
                    num = numbers[1];

                while (num != 0)
                {
                    sum += (int)(num % 10);
                    num /= 10;
                }
                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
