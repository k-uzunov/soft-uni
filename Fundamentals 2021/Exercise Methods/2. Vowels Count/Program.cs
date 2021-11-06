using System;

namespace _2._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();

            vowelsCounter(word);
        }

        static void vowelsCounter(char[] word)
        {
            char[] vowels =
            {
                'a', 'e', 'u', 'o', 'i', 'A', 'E', 'U', 'O','I'
            };

            int count = 0;

            for(int i = 0; i< word.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (word[i] == vowels[j]) count++;
                }
            }
                

            Console.WriteLine(count);
        }
    }
}
