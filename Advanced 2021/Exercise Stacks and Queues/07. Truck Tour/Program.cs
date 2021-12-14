using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<int []> petrolPumps = new Queue<int[]> { };

            for(int i = 0; i <numberOfPumps; i++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                petrolPumps.Enqueue(input);
            }

            int startPump = 0;
            bool circleNotComplete = true;

            while (circleNotComplete)
            {
                int fuelInTank = 0;
                foreach(int[] pump in petrolPumps)
                {
                    fuelInTank += pump[0];
                    fuelInTank -= pump[1];
                    if (fuelInTank < 0)
                    {
                        startPump++;
                        int[] temp = petrolPumps.Dequeue();
                        petrolPumps.Enqueue(temp);
                        break;
                    }
                }

                if(fuelInTank >= 0)
                {
                    Console.WriteLine(startPump);
                    circleNotComplete = false;
                }
            }



        }
    }
}