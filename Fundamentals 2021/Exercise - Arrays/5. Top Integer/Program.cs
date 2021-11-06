using System;
using System.Linq;

namespace _5._Top_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isBigger = false;

            for (int i = 0; i < arrayInput.Length; i++)
            {
                for (int j = i + 1; j < arrayInput.Length; j++)
                {
                    if (arrayInput[i] > arrayInput[j])
                    {
                        isBigger = true;
                    }
                    else
                    {
                        isBigger = false;
                        break;
                    }


                }
                if (i == arrayInput.Length - 1)
                {
                    isBigger = true;
                }


                if (isBigger == true)
                {
                    Console.Write(arrayInput[i] + " ");
                }
            }
            

            //Doesn't pass Test #3
            /*
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            for(int i = 0; i < numbers.Length; i++)
            {
                bool topNumber = true;

                for(int j = i; j < numbers.Length; j++)
                {
                    if(numbers[i] < numbers[j])
                    {
                        topNumber = false;
                        break;
                    }
                }

                if (topNumber) Console.Write(numbers[i] + " ");
            }

            */
        }
    }
}
