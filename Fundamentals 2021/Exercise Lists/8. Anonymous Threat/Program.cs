//Тестове #6 и #7 гърмят, все още нямам представа защо
using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ").ToList();
            string[] command = Console.ReadLine().Split(" ");

            while (command[0] != "3:1")
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

        static void Merge(List<string> text, int startIndex, int endIndex)
        {
            if (startIndex < 0) startIndex = 0;
            if (endIndex > text.Count - 1) endIndex = text.Count - 1;

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                text[startIndex] += text[startIndex + 1];
                text.RemoveAt(startIndex + 1);
            }
        }

        static void Divide(List<string> text, int index, int partitions)
        {
            string partData = text[index];
            text.RemoveAt(index);
            int partSize = partData.Length / partitions;
            int reminder = partData.Length % partitions;

            List<string> tempData = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                string tempString = null;

                for (int j = 0; j < partSize; j++)
                {
                    tempString += partData[(i * partSize) + j];
                }

                if (i == partitions - 1 && reminder != 0)
                {
                    tempString += partData.Substring(partData.Length - reminder);
                }

                tempData.Add(tempString);
            }
            text.InsertRange(index, tempData);
        }
    }
}
