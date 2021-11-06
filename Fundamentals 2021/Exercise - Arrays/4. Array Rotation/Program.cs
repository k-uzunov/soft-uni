using System;

namespace _4._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine());
            string firstElement;

            if(rotations % array.Length != 0)
            {
                for(int i = 0; i < (rotations % array.Length); i++)
                {
                    firstElement = array[0];

                    for(int j = 1; j < array.Length; j++)
                    {
                        array[j-1] = array[j];
                    }

                    array[array.Length - 1] = firstElement;
                }
            }

            Console.WriteLine(string.Join(" ", array));

        }
    }
}
