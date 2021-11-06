using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a single integer.Your task is to find the sum of its digits.

            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number >= 1)
            {
                int x = number % 10;
                sum += x;
                number /= 10;

            }
            Console.WriteLine(sum);
        }
    }
}
