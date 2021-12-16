using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            for(int i = 0; i<matrixSize; i++)
            {
                int[] inputLine = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                
                for(int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = inputLine[j];
                }
            }
            
            int diagonalOne = 0;
            int diagonalTwo = 0;
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                diagonalOne += matrix[i, i];
                diagonalTwo += matrix[i, (matrix.GetLength(0) - 1)- i];
            }

            int absDifference = Math.Abs(diagonalOne - diagonalTwo);
            Console.WriteLine(absDifference);
        }
    }
}
