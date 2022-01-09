using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];
                string evenOrOdd;
                int count;
                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(commandArgs[1]);
                        Exchange(numbers, index);
                        break;

                    case "max":
                        evenOrOdd = commandArgs[1];
                        int maxIndex = GetMaxIndex(numbers, evenOrOdd);
                        if (maxIndex < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(maxIndex);
                        }
                        break;
                    case "min":
                        evenOrOdd = commandArgs[1];
                        int minIndex = GetMinIndex(numbers, evenOrOdd);
                        if (minIndex < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(minIndex);
                        }
                        break;
                    case "first":
                        count = int.Parse(commandArgs[1]);
                        evenOrOdd = commandArgs[2];
                        

                        if(numbers.Length < count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            int[] first = FirstElements(evenOrOdd, count, numbers);
                            
                            if (first.Length == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{String.Join(", ", first)}]");
                            }
                        }

                        break;
                    case "last":
                        count = int.Parse(commandArgs[1]);
                        evenOrOdd = commandArgs[2];

                        if (numbers.Length < count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            int[] last = LastElements(evenOrOdd, count, numbers);

                            if (last.Length == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{String.Join(", ", last)}]");
                            }
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{String.Join(", ", numbers)}]");
        }

        static void Exchange(int[] array, int index)
        {
            //Split the array at the given index and exchange the two parts
            if (index >= 0 && index < array.Length)
            {
                int[] subArray1 = new int[index + 1];
                int[] subArray2 = new int[array.Length - (index + 1)];
                for (int i = 0; i < array.Length; i++)
                {
                    if (i <= index)
                    {
                        subArray1[i] = array[i];
                    }
                    else
                    {
                        subArray2[i - (index + 1)] = array[i];
                    }
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if (i < subArray2.Length)
                    {
                        array[i] = subArray2[i];
                    }
                    else
                    {
                        array[i] = subArray1[i - subArray2.Length];
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

        }

        static int GetMaxIndex(int[] array, string type)
        {
            int maxIndex = -1;
            int maxInt = int.MinValue;

            if (type == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= maxInt && array[i] % 2 == 0)
                    {
                        maxIndex = i;
                        maxInt = array[i];
                    }
                }
            }
            else if (type == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= maxInt && array[i] % 2 != 0)
                    {
                        maxIndex = i;
                        maxInt = array[i];
                    }
                }
            }

            return maxIndex;
               
        }

        static int GetMinIndex(int[] array, string type)
        {
            int minIndex = -1;
            int minInt = int.MaxValue;

            if (type == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] <= minInt && array[i] % 2 == 0)
                    {
                        minIndex = i;
                        minInt = array[i];
                    }
                }
            }
            else if (type == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] <= minInt && array[i] % 2 != 0)
                    {
                        minIndex = i;
                        minInt = array[i];
                    }
                }
            }

            return minIndex;

        }

        static int[] FirstElements(string type, int count, int[] array)
        {
            int arrayLength = 0;
            int[] result = new int[0];
            int resultIndex = 0;

            if (type == "even")
            {
                for (int i = 0; i < array.Length && arrayLength < count; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        arrayLength++;
                    }
                    
                }

                result = new int[arrayLength];

                for (int i = 0; i < array.Length && resultIndex < arrayLength; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        result[resultIndex] = array[i];
                        resultIndex++;
                    }
                }
            }
            else if (type == "odd")
            {
                for (int i = 0; i < array.Length && arrayLength < count; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        arrayLength++;
                    }
                }

                result = new int[arrayLength];

                for (int i = 0; i < array.Length && resultIndex < arrayLength; i++)
                {
                   if (array[i] % 2 != 0)
                   {
                        result[resultIndex] = array[i];
                        resultIndex++;
                   }
                }
            }

            return result;

        }

        static int[] LastElements(string type, int count, int[] array)
        {
            int arrayLength = 0;
            int[] result = new int[0];
            

            if (type == "even")
            {
                for (int i = 0; i < array.Length && arrayLength < count; i++)
                {
                    if (array[i] % 2 == 0 && array[i] != 0)
                    {
                        arrayLength++;
                    }

                }

                result = new int[arrayLength];
                int resultIndex = arrayLength - 1;

                for (int i = array.Length - 1; i >= 0 && resultIndex >= 0; i--)
                {
                    if (array[i] % 2 == 0 && array[i] != 0)
                    {
                        result[resultIndex] = array[i];
                        resultIndex--;
                    }
                }
            }

            else if (type == "odd")
            {
                for (int i = 0; i < array.Length && arrayLength < count; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        arrayLength++;
                    }
                }

                result = new int[arrayLength];
                int resultIndex = arrayLength - 1;

                for (int i = array.Length - 1; i >= 0 && resultIndex >= 0; i--)
                {
                    if (array[i] % 2 != 0)
                    {
                        result[resultIndex] = array[i];
                        resultIndex--;
                    }
                }
            }

            return result;
        }

    }
}
