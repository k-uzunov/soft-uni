using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> merged = Merge(firstList, secondList);

            Console.WriteLine(string.Join(" ", merged));
        }

        private static List<int> Merge(List<int> listA, List<int> listB)
        {
            List<int> result = new List<int> { };

            while (listA.Count > 0 && listB.Count > 0)
            {
                result.Add(listA[0]);
                listA.RemoveAt(0);
                result.Add(listB[0]);
                listB.RemoveAt(0);
            }

            if (listB.Count > 0)
            {
                for (int i = 0; i < listB.Count; i++)
                {
                    result.Add(listB[i]);
                }
            }
            else if (listA.Count > 0)
            {
                for (int i = 0; i < listA.Count; i++)
                {
                    result.Add(listA[i]);
                }
            }

            return result;
        }
    }
}
