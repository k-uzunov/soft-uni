using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    integers.RemoveAll(x => x == int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    integers.Insert(index, number);
                }
                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}