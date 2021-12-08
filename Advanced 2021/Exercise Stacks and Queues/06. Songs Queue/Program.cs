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

            

            while (songsQueue.Count()>0)
            {

                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

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

            }

            Console.WriteLine("No more songs!");

        }
    }
}
