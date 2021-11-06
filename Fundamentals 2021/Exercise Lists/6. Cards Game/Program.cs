using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();
            List<int> playerTwo = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            do
            {
                if (playerOne[0] > playerTwo[0])
                {
                    playerOne.Add(playerOne[0]);
                    playerOne.Add(playerTwo[0]);
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
                else if (playerTwo[0] > playerOne[0])
                {
                    playerTwo.Add(playerTwo[0]);
                    playerTwo.Add(playerOne[0]);
                    playerTwo.RemoveAt(0);
                    playerOne.RemoveAt(0);
                }
                else
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
            } while (playerOne.Count > 0 && playerTwo.Count > 0);

            //Test output
            /*Console.WriteLine("deck one");
            Console.WriteLine(string.Join(" ", playerOne));
            Console.WriteLine("deck two");
            Console.WriteLine(string.Join(" ", playerTwo));
            */

            //if (playerOne.Count > 0) Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
            //else Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
            Console.WriteLine(playerOne.Count < playerTwo.Count ? $"Second player wins! Sum: {playerTwo.Sum()}" : $"First player wins! Sum: {playerOne.Sum()}");
        
        }
    }
}
//"{First/Second} player wins! Sum: {sum}"