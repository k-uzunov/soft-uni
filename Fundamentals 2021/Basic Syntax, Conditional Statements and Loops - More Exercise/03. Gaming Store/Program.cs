using System;
using System.IO;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            float currentBalance = float.Parse(Console.ReadLine());
            float moneySpent = 0;
            string command = Console.ReadLine();
            float outFall4 = 39.99F;
            float csOG = 15.99F;
            float zplinterZell = 19.99F;
            float honored2 = 59.99F;
            float roverWatch = 29.99F;
            float roverWatchOriginsEdition = 39.99F;



            while(command != "Game Time")
            {
                
                switch (command)
                {

                    case "OutFall 4":
                        if (currentBalance < outFall4)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {command}");
                            currentBalance -= outFall4;
                            moneySpent += outFall4;

                        }
                        break;
                    case "CS: OG":
                        if (currentBalance < csOG)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {command}");
                            currentBalance -= csOG;
                            moneySpent += csOG;

                        }
                        break;
                    case "Zplinter Zell":
                        if (currentBalance < zplinterZell)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {command}");
                            currentBalance -= zplinterZell;
                            moneySpent += zplinterZell;

                        }
                        break;
                    case "Honored 2":
                        if (currentBalance < honored2)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {command}");
                            currentBalance -= honored2;
                            moneySpent += honored2;
                        }
                        break;
                    case "RoverWatch":
                            if (currentBalance < roverWatch)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine($"Bought {command}");
                                currentBalance -= roverWatch;
                                moneySpent += roverWatch;
                            }
                        break;
                    case "RoverWatch Origins Edition":
                        if (currentBalance < roverWatchOriginsEdition)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine($"Bought {command}");
                            currentBalance -= roverWatchOriginsEdition;
                            moneySpent += roverWatchOriginsEdition;
                        }
                        break;
                    default: Console.WriteLine("Not Found"); break;
                }

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${moneySpent:f2}. Remaining: ${currentBalance:f2}");

        }
    }
}
