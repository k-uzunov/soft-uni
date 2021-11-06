using System;

namespace _9._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            float money = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float lightsaberPrice = float.Parse(Console.ReadLine());
            float robePrice = float.Parse(Console.ReadLine());
            float beltPrice = float.Parse(Console.ReadLine());
            float totalPrice = 0;

            totalPrice = (float)((students * beltPrice) + (students * robePrice) + ((students * lightsaberPrice) + (Math.Ceiling(students * 0.1) * lightsaberPrice)));
            totalPrice -= (students / 6) * beltPrice;

            if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                //В джъдж името е John
                Console.WriteLine($"Ivan Cho will need {(totalPrice - money):F2}lv more.");
            }

        }
    }
}
