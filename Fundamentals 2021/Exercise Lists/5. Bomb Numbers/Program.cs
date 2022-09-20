using System;
using System.Collections.Generic;
using System.Linq;
namespace _5._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] bombParameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = bombParameters[0];
            int bombPower = bombParameters[1];

            while (numbers.Contains(bomb))
            {
                int bombIndex = numbers.IndexOf(bomb);

                if (bombIndex == 0) numbers.RemoveRange(bombIndex, bombPower + 1);

                else if (bombIndex == numbers.Count - 1) numbers.RemoveRange(bombIndex - bombPower, bombPower + 1);

                else
                {
                    if (bombIndex + bombPower > numbers.Count - 1)
                    {
                        int itemsToRemove = (numbers.Count - 1) - bombIndex;
                        numbers.RemoveRange(bombIndex + 1, itemsToRemove);
                    }
                    else
                    {
                        numbers.RemoveRange(bombIndex + 1, bombPower);
                    }

                    if (bombIndex - bombPower < 0)
                    {
                        numbers.RemoveRange(0, bombIndex + 1);
                    }
                    else
                    {
                        numbers.RemoveRange(bombIndex - bombPower, bombPower + 1);
                    }
                }

            }

            //Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(numbers.Sum());
        }
    }
}