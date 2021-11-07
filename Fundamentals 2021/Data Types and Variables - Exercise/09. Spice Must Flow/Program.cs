using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            int days = 0;

            while (yield >=100)
            {
                days++;
                totalAmount += yield - 26;
                yield -= 10;
            }

            if (totalAmount > 26) totalAmount -= 26;


            Console.Write(days+"\n"+totalAmount);
        }
    }
}
