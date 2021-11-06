using System;

namespace _10._Rage_Expense
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            float expenses = 0;

            int trashedHeadsets = 0, trashedMouses = 0, trashedKeyboards = 0, trashedDisplays = 0;

            for(int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                    trashedHeadsets++;
                if (i % 3 == 0)
                    trashedMouses++;
                if (i % 6 == 0)
                    trashedKeyboards++;
                if (i % 12 == 0)
                    trashedDisplays++;
            }

            expenses = (trashedHeadsets * headsetPrice) + (trashedMouses * mousePrice) + (trashedKeyboards * keyboardPrice) + (trashedDisplays * displayPrice);
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");

        }
    }
}
