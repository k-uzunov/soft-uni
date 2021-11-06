using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate how many courses will be needed to elevate n persons by using an elevator of capacity of p persons.
            //The input holds two lines: the number of people n and the capacity p of the elevator.

            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            if (people <= capacity) Console.WriteLine(1);
            else
            {
                if(people % capacity != 0) Console.WriteLine((people/capacity)+1);
                else Console.WriteLine(people/capacity);
            }
        }
    }
}
