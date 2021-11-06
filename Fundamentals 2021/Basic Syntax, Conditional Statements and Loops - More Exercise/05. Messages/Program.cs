using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());
            char[] message = new char[numOfInputs];

            for (int i = 0; i < numOfInputs; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if(input != 0)
                {

                    int numberOfDigits = 0;
                    int mainDigit = input % 10;
                    int offset = (mainDigit - 2) * 3;

                    if (mainDigit == 8 || mainDigit == 9)
                        offset++;

                    int x = input;
                    while (x > 0)
                    {
                        numberOfDigits++;
                        x /= 10;
                    }

                    int letterIndex = offset + numberOfDigits - 1;
                    int ascii = 97 + letterIndex;
                    message[i] = (char)ascii;
                } else
                {
                    message[i] = ' ';
                }
            }

            Console.WriteLine(String.Join("", message));
        }
    }
}
