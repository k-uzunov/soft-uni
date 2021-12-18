using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger topSnowballValue = 0;
            int topSnowballSnow = 0;
            int topSnowballTime = 0;
            int topSnowballQuality = 0;
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSnowballs; i++) 
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                
                if(snowballValue > topSnowballValue)
                {
                    topSnowballValue = snowballValue;
                    topSnowballSnow = snowballSnow;
                    topSnowballTime = snowballTime;
                    topSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine("{0} : {1} = {2} ({3})",topSnowballSnow, topSnowballTime, topSnowballValue, topSnowballQuality);
            
        }
    }
}
