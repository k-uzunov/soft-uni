using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songsQueue = new Queue<string> { };
            string[] songsInput = Console.ReadLine().Split(", ").ToArray();

            foreach(string song in songsInput)
            {
                songsQueue.Enqueue(song);
            }

            string[] command = Console.ReadLine().Split(" ").ToArray();

            while (songsQueue.Count()>0)
            {
                switch (command[0])
                {
                    case "Play":
                        songsQueue.Dequeue();
                        break;
                    case "Add":
                        string song = string.Join(" ", command, 1, command.Count() - 1);
                        if (songsQueue.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            songsQueue.Enqueue(song);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songsQueue));
                        break;
                }

                command = Console.ReadLine().Split(" ").ToArray();

            }

            Console.WriteLine("No more songs!");

        }
    }
}
