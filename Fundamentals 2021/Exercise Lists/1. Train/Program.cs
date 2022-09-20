using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Add")
                {
                    wagons.Add(int.Parse(commandArgs[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(commandArgs[0]) <= maxCapacity)
                        {
                            wagons[i] += int.Parse(commandArgs[0]);
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
