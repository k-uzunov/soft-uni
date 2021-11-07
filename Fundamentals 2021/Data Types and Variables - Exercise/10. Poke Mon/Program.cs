using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhuastionFactor = int.Parse(Console.ReadLine());

            int pokesCount = 0;
            double halfPower = pokePower * 0.5;

            while(pokePower >= distance)
            {
                pokePower -= distance;
                pokesCount++;
                
                if(pokePower == halfPower)
                {
                    if(pokePower >= exhuastionFactor && exhuastionFactor!=0)
                    {
                        pokePower /= exhuastionFactor;
                    }
                }

            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokesCount);
        }
    }
}
