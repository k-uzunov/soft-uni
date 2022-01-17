using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split(" ");

            while(command[0] != "3:1")
            {
                switch (command[0])
                {
                    case "merge":
                        Merge(input, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "divide":
                        Divide(input, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", input));


        }

        static void Merge(List<string> listToMerge, int startIndex, int endIndex)
        {
            if (startIndex < 0) startIndex = 0;
            else if(startIndex >= listToMerge.Count) startIndex = listToMerge.Count - 1;

            if (endIndex >= listToMerge.Count) endIndex = listToMerge.Count - 1;
            else if (endIndex < 0) endIndex = 0;

            int end = endIndex - startIndex;

            for (int i = 0; i < end; i++)
            {
                listToMerge[startIndex] = string.Concat(listToMerge[startIndex], listToMerge[startIndex+1]);
                listToMerge.RemoveAt(startIndex+1);
            }
        }

        static void Divide(List<string> listToDivide, int index, int partitions)
        {
            int partitionSize = listToDivide[index].Length / partitions;
            string stringToDivide = listToDivide[index];
            listToDivide.RemoveAt(index);

            int startIndex = 0;

            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions-1)
                {
                    listToDivide.Add(stringToDivide.Substring(startIndex));
                }
                else
                {
                    listToDivide.Add(stringToDivide.Substring(startIndex, partitionSize));
                    startIndex += partitionSize;
                }

            }

        }
    }
}
