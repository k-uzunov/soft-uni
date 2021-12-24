using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugs = new int[fieldSize];
            //ladyBugs.Initialize();

            int[] indexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            foreach (int index in indexes)
            {
                if (index >= 0 && index < fieldSize)
                {
                    ladyBugs[index] = 1;
                }
            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "end")
            {
                int index = int.Parse(command[0]);
                string direction = command[1];
                int length = int.Parse(command[2]);

                if (index >= 0 && index < fieldSize && ladyBugs[index] == 1 && length !=0)
                {
                    if (direction == "right")
                    {
                        int newIndex = index + length;

                        while (newIndex >= 0 && newIndex < fieldSize)
                        {
                            if (ladyBugs[newIndex] == 1)
                            {
                                //New index is ocupied. Ladybug flies length number indexes to the right
                                newIndex += length;
                            }
                            else
                            {
                                ladyBugs[index] = 0;
                                ladyBugs[newIndex] = 1;
                                break;
                            }
                        }

                        if (newIndex < 0 || newIndex >= fieldSize)
                        {
                            //Ladybug flies of the field
                            ladyBugs[index] = 0;
                        }
                    }
                    else if (direction == "left")
                    {
                        int newIndex = index - length;

                        while (newIndex >= 0 && newIndex < fieldSize)
                        {
                            if (ladyBugs[newIndex] == 1)
                            {
                                //New index is ocupied. Ladybug flies length number indexes to the left.
                                newIndex -= length;
                            }
                            else
                            {
                                ladyBugs[index] = 0;
                                ladyBugs[newIndex] = 1;
                                break;
                            }
                        }

                        if (newIndex < 0 || newIndex >= fieldSize)
                        {
                            //Ladybug flies of the field
                            ladyBugs[index] = 0;
                        }
                    }
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" ", ladyBugs));
        }
    }
}
