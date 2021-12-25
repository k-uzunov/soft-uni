using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            int[] encryptedText = new int[numberOfStrings];

            for (int i = 0; i < encryptedText.Length; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                int sum = 0;
                foreach (char letter in input)
                {
                    if (char.ToLower(letter) == 'a' || char.ToLower(letter) == 'e' || char.ToLower(letter) == 'i' || char.ToLower(letter) == 'o' || char.ToLower(letter) == 'u')
                    {
                        sum += (int)letter * input.Length;
                    }
                    else
                    {
                        sum += (int)letter / input.Length;
                    }
                }

                encryptedText[i] = sum;
            }

            Array.Sort(encryptedText);

            foreach(int word in encryptedText)
            {
                Console.WriteLine(word);
            }

        }
    }
}
