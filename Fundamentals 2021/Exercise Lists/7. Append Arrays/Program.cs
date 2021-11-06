using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split("|").ToList();
            arrays.Reverse();
            string appendedArray = String.Join(" ", arrays);

            List<int> numbers = appendedArray.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}