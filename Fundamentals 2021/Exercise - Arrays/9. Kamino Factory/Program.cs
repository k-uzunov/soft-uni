using System;
using System.Linq;

namespace _9._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] bestSequence = new int[dnaLength];
            int bestSubsequence = 0;
            int bestStartingIndex = dnaLength;
            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;
            int index = 0;

            while (input != "Clone them!")
            {
                index++;
                
                int[] dnaSequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int longestSubseqLength = 0;
                int startingIndex = 0;
                for (int i = 0; i < dnaLength; )
                {
                    int currentSubseqLength = 0;
                    int currentIndex = i;
                    if (dnaSequence[i] == 1)
                    {
                           
                        for(int j = i; j < dnaLength && dnaSequence[j] != 0; j++)
                        {
                            currentSubseqLength++;
                            i++;
                        }
                        if(currentSubseqLength > longestSubseqLength)
                        {
                            longestSubseqLength = currentSubseqLength;
                            startingIndex = currentIndex;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
                if (longestSubseqLength > bestSubsequence)
                {
                    bestSubsequence = longestSubseqLength;
                    bestSequence = dnaSequence;
                    bestSequenceIndex = index;
                    bestSequenceSum = dnaSequence.Sum();
                    bestStartingIndex = startingIndex;
                }
                else if(longestSubseqLength == bestSubsequence)
                {
                    if(startingIndex < bestStartingIndex)
                    {
                        bestSubsequence = longestSubseqLength;
                        bestSequence = dnaSequence;
                        bestSequenceIndex = index;
                        bestSequenceSum = dnaSequence.Sum();
                        bestStartingIndex = startingIndex;
                    }
                    else if (startingIndex == bestStartingIndex)
                    {
                        if(bestSequence.Sum() < dnaSequence.Sum())
                        {
                            bestSubsequence = longestSubseqLength;
                            bestSequence = dnaSequence;
                            bestSequenceIndex = index;
                            bestSequenceSum = dnaSequence.Sum();
                            bestStartingIndex = startingIndex;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            //"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
            //"{DNA sequence, joined by space}"

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));

        }
    }
}