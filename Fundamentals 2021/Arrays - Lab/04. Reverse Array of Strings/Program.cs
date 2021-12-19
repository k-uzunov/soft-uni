using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] reversed = new string[input.Length];

            for (int i = 0; i<input.Length; i++)
            {
                reversed[(input.Length - 1) - i] = input[i];
            }

            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
