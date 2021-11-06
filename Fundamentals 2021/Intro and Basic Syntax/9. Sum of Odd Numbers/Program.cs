using System;

namespace _9._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j = 0, sum = 0;
            for(int i = 0; j<n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    j++;
                }
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
