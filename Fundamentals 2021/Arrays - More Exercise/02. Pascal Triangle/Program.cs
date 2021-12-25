using System;
using System.Numerics;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            BigInteger[] currentRow = new BigInteger[] { };

            for(int i = 1; i <= rows; i++)
            {
                BigInteger[] newRow = new BigInteger[i];
                for (int j = 0; j < i; j++)
                {
                    if(j == 0 || j == i - 1)
                    {
                        newRow[j] = 1;
                    }
                    else
                    {
                        newRow[j] = currentRow[j - 1] + currentRow[j];
                    }
                }

                Console.WriteLine(string.Join(" ", newRow));
                currentRow = new BigInteger[currentRow.Length];
                currentRow = newRow;
            }
        }
    }
}
