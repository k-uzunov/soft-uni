using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            //int[] firstRow = new int[2 * k];
            //int[] secondRow = new int[2 * k];
            int[] foldedNumbers = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                foldedNumbers[i] = numbers[(k - 1) - i] + numbers[k + i];
                //firstRow[i] = numbers[(k - 1) - i];
                //secondRow[i] = numbers[k + i];
                foldedNumbers[i + k] = numbers[((4 * k) - 1) - i] + numbers[(2 * k) + i];
                //firstRow[k + i] = numbers[((4 * k) - 1) - i];
                //secondRow[i+k] = numbers[(2*k) + i];
            }
            
            /*for (int i = 0; i < 2 * k; i++)
            {
                foldedNumbers[i] = firstRow[i] + numbers[k + i];
            }*/

            /*for(int i = 0; i < 2*k; i++)
            {
                foldedNumbers[i] = firstRow[i] + secondRow[i];
            }*/

            Console.WriteLine(string.Join(" ", foldedNumbers));

        }
    }
}
