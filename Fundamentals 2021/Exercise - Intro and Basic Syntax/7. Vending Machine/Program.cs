using System;

namespace _7._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string product = string.Empty;
            double coin = 0;
            double totalMoney = 0;
            //double change = 0;

            do
            {
                //Insert coins

                coin = double.Parse(command);
                switch (coin)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        totalMoney += coin;
                        coin = 0;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }
                command = Console.ReadLine();
            } while (command != "Start");
            //Console.WriteLine(totalMoney);
            command = Console.ReadLine();
            do
            {
                double price = 0;
                switch (command)
                {
                    case "End":
                        break;
                    case "Nuts":
                        price = 2.0;
                        if (totalMoney >= price)
                        {
                            Console.WriteLine("Purchased nuts");
                            totalMoney -= price;
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Water":
                        price = 0.7;
                        if (totalMoney >= price)
                        {
                            Console.WriteLine("Purchased water");
                            totalMoney -= price;
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Crisps":
                        price = 1.5;
                        if (totalMoney >= price)
                        {
                            Console.WriteLine("Purchased crisps");
                            totalMoney -= price;
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Soda":
                        price = 0.8;
                        if (totalMoney >= price)
                        {
                            Console.WriteLine("Purchased soda");
                            totalMoney -= price;
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Coke":
                        price = 1.0;
                        if (totalMoney >= price)
                        {
                            Console.WriteLine("Purchased coke");
                            totalMoney -= price;
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                command = Console.ReadLine();

            } while (command != "End");

            Console.WriteLine($"Change: {totalMoney:F2}");

        }
    }
}
