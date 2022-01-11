using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            bool changed = false;

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        changed = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        changed = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        changed = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        changed = true;
                        break;
                    case "Contains":
                        Console.WriteLine(numbers.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        PrintEven(numbers);
                        break;
                    case "PrintOdd":
                        PrintOdd(numbers);
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        Filter(command[1], int.Parse(command[2]), numbers);
                        break;
                }


                command = Console.ReadLine().Split();
            }

            if (changed)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        private static void Filter(string condition, int number, List<int> numbers)
        {
            List<int> result = new List<int> { };
            switch (condition)
            {
                case "<":
                    foreach (var item in numbers)
                    {
                        if (item < number)
                        {
                            result.Add(item);
                        }
                    }
                    break;
                case ">":
                    foreach (var item in numbers)
                    {
                        if (item > number)
                        {
                            result.Add(item);
                        }
                    }
                    break;
                case "<=":
                    foreach (var item in numbers)
                    {
                        if (item <= number)
                        {
                            result.Add(item);
                        }
                    }
                    break;
                case ">=":
                    foreach (var item in numbers)
                    {
                        if (item >= number)
                        {
                            result.Add(item);
                        }
                    }
                    break;
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static void PrintOdd(List<int> numbers)
        {
            List<int> odd = new List<int> { };
            foreach (int item in numbers)
            {
                if (item % 2 != 0)
                {
                    odd.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", odd));
        }

        private static void PrintEven(List<int> numbers)
        {
            List<int> even = new List<int> { };
            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    even.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", even));
        }
    }
}
