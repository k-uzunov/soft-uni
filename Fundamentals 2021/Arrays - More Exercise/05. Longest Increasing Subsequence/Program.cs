using System;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] len = new int[nums.Length];
            int[] prev = new int[nums.Length];
            for (int p = 0; p < nums.Length; p++)
            {
                len[p] = 1;
                prev[p] = -1;

                for (int left = 0; left < p; left++)
                {
                    if (nums[left] < nums[p])
                    {
                        //If left number is smaller than number on the position
                        //Save it's position, and increase the legth
                        len[p] = len[left] + 1;
                        prev[p] = left;
                    }
                }
            }
            int[] subsequence = new int[len.Max()];
            int index = subsequence.Length - 1;
            for(int i = Array.IndexOf(len, len.Max()); i >=0;)
            {
                subsequence[index] = nums[i];
                index--;
                i = prev[i];
            }


            //Console.WriteLine(string.Join(" || ", nums));
            //Console.WriteLine(string.Join(" || ", len));
            //Console.WriteLine(string.Join(" || ", prev));

            Console.WriteLine(string.Join(" ", subsequence));

        }
    }
}
