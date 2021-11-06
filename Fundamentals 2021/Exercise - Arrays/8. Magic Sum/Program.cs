using System;
using System.Linq;

namespace _8._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            for(int i = 0; i < integers.Length-1; i++)
            {
                for(int j =i+1; j<integers.Length; j++)
                {
                    if(integers[i] + integers[j] == sum)
                    {
                        Console.WriteLine(integers[i] + " " + integers[j]);
                    }
                }
            }
        }
    }
}
