using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            // •	coffee – 1.50
            // •	water – 1.00
            // •	coke – 1.40
            // •	snacks – 2.00

            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            TotalPrice(product, quantity);
        }

        static void TotalPrice(string item, int quantity)
        {
            double totalPrice = 0;
            
            switch (item)
            {
                case "coffee":
                    totalPrice = quantity * 1.50;
                    break;
                case "water":
                    totalPrice = quantity * 1.00;
                    break;
                case "coke":
                    totalPrice = quantity * 1.40;
                    break;
                case "snacks":
                    totalPrice = quantity * 2.00;
                    break;

                default:
                    break;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
