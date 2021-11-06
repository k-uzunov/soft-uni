using System;
using System.Collections.Generic;
using System.Linq;
namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while(command[0] != "End")
            {
                if(command[0] == "Add")
                {
                    int item = int.Parse(command[1]);
                    numbers.Add(item);
                }else if(command[0] == "Insert")
                {
                    int item = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    if(index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, item);
                    }
                }else if(command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }else if (command[0] == "Shift")
                {
                    int count = int.Parse(command[2]);
                    if(command[1] == "left")
                    {
                        for(int i = 0; i < count % numbers.Count; i++)
                        {
                            int temp = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(temp);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count % numbers.Count; i++)
                        {
                            int temp = numbers[numbers.Count-1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, temp);
                        }
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

    }
}
