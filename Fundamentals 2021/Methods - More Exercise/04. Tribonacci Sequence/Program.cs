using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] tribunacci = GetTribunacci(num);

            Console.WriteLine(string.Join(" ", tribunacci));
        }

        private static int[] GetTribunacci(int num)
        {
            int[] result = new int[num];
            result[0] = 1;
            for (int i = 1; i < num; i++)
            {
                if (i < 3)
                {
                    result[i] = i;
                }
                else
                {
                    result[i] = result[i - 1] + result[i - 2] + result[i - 3];
                }
                
            }

            return result;
        }

        
    }
}
