using System;

namespace _3._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0, totalPrice = 0;

            switch (day)
            {
                case "Friday":
                    switch (groupType)
                    {
                        case "Students":
                            price = 8.45;
                            totalPrice = group * price;
                            if (group >= 30)
                                totalPrice = totalPrice - (totalPrice * 0.15);
                            break;
                        case "Business":
                            price = 10.90;
                            totalPrice = group * price;
                            if (group >= 100)
                                totalPrice = totalPrice - (10 * price);
                            break;
                        case "Regular":
                            price = 15;
                            totalPrice = group * price;
                            if (group >= 10 && group<= 20)
                                totalPrice = totalPrice - (totalPrice * 0.05);
                            break;

                    }
                    break;

                case "Saturday":
                    switch (groupType)
                    {
                        case "Students":
                            price = 9.80;
                            totalPrice = group * price;
                            if (group >= 30)
                                totalPrice = totalPrice - (totalPrice * 0.15);
                            break;
                        case "Business":
                            price = 15.60;
                            totalPrice = group * price;
                            if (group >= 100)
                                totalPrice = totalPrice - (10 * price);
                            break;
                        case "Regular":
                            price = 20;
                            totalPrice = group * price;
                            if (group >= 10 && group <= 20)
                                totalPrice = totalPrice - (totalPrice * 0.05);
                            break;

                    }
                    break;

                case "Sunday":
                    switch (groupType)
                    {
                        case "Students":
                            price = 10.46;
                            totalPrice = group * price;
                            if (group >= 30)
                                totalPrice = totalPrice - (totalPrice * 0.15);
                            break;
                        case "Business":
                            price = 16;
                            totalPrice = group * price;
                            if (group >= 100)
                                totalPrice = totalPrice - (10 * price);
                            break;
                        case "Regular":
                            price = 22.50;
                            totalPrice = group * price;
                            if (group >= 10 && group <= 20)
                                totalPrice = totalPrice - (totalPrice * 0.05);
                            break;

                    }
                    break;

            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
