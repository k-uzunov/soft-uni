using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] left = new int[n];
            int[] right = new int[n];

            for(int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(i%2 == 0)
                {
                    left[i] = input[0];
                    right[i] = input[1];
                }
                else
                {
                    left[i] = input[1];
                    right[i] = input[0];
                }
            }

            Console.WriteLine(string.Join(" ", left));
            Console.WriteLine(string.Join(" ", right));
        }
    }
}
