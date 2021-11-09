using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInTheBox = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothesStack = new Stack<int> { };

            int numberOfRacks = 1;
            int currentRack = 0;

            foreach (var item in clothesInTheBox)
            {
                clothesStack.Push(item);
            }

            while (clothesStack.Count > 0)
            {
                if((currentRack + clothesStack.Peek()) <= rackCapacity)
                {
                    currentRack += clothesStack.Pop();
                }
                else
                {
                    currentRack = 0;
                    numberOfRacks++;
                }
            }

            Console.WriteLine(numberOfRacks);
        }
    }
}
