using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;

namespace _02._Armory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] armory = new char[n, n];

            int[][] mirrorCoord = new int[2][];
            int mirror = 0;
            int currentX = 0;
            int currentY = 0;
            int profit = 0;
            for(int i = 0; i<n; i++)
            {
                char[] inputRow = Console.ReadLine().ToCharArray();
                for (int j = 0; j<n; j++)
                {
                    if(inputRow[j] == 'A')
                    {
                        currentX = i;
                        currentY = j;
                    }else if(inputRow[j] == 'M')
                    {
                        mirrorCoord[mirror] = new int[] { i, j };
                        mirror++;
                    }
                    armory[i, j] = inputRow[j];
                }
            }
            
            while (profit < 65)
            {
                string command = Console.ReadLine();

                if(command == "up")
                {
                    if (currentX-1 < 0) {
                        //Leaves the Armory
                        Console.WriteLine("I do not need more swords!");
                        Console.WriteLine($"The king paid {profit} gold coins.");
                        armory[currentX, currentY] = '-';
                        break;
                    }
                    else if (armory[(currentX - 1), currentY] == 'M')
                    {
                        //Teleport to the other mirror
                        if((currentX - 1 == mirrorCoord[0][0]) && currentY == mirrorCoord[0][1])
                        {
                            armory[(currentX - 1), currentY] = '-';
                            armory[currentX, currentY] = '-';
                            armory[mirrorCoord[1][0], mirrorCoord[1][1]] = 'A';
                            currentX = mirrorCoord[1][0];
                            currentY = mirrorCoord[1][1];
                        }
                        else
                        {
                            armory[(currentX - 1), currentY] = '-';
                            armory[currentX, currentY] = '-';
                            armory[mirrorCoord[0][0], mirrorCoord[0][1]] = 'A';
                            currentX = mirrorCoord[0][0];
                            currentY = mirrorCoord[0][1];
                        }
                        
                    }
                    else
                    {
                        if (Char.IsNumber(armory[(currentX - 1), currentY]))
                        {
                            //Buys Sword
                            profit += int.Parse(armory[(currentX - 1), currentY].ToString());
                        }

                        //Moves
                        armory[currentX, currentY] = '-';
                        armory[currentX - 1, currentY] = 'A';
                        currentX--;
                    }
                }
                else if(command == "down")
                {
                    if (currentX + 1 >= n)
                    {
                        //Leaves the Armory
                        Console.WriteLine("I do not need more swords!");
                        Console.WriteLine($"The king paid {profit} gold coins.");
                        armory[currentX, currentY] = '-';
                        break;
                    }
                    else if (armory[(currentX + 1), currentY] == 'M')
                    {
                        //Teleport to the other mirror
                        if ((currentX + 1 == mirrorCoord[0][0]) && currentY == mirrorCoord[0][1])
                        {
                            armory[(currentX + 1), currentY] = '-';
                            armory[currentX, currentY] = '-';
                            armory[mirrorCoord[1][0], mirrorCoord[1][1]] = 'A';
                            currentX = mirrorCoord[1][0];
                            currentY = mirrorCoord[1][1];
                        }
                        else
                        {
                            armory[(currentX + 1), currentY] = '-';
                            armory[currentX, currentY] = '-';
                            armory[mirrorCoord[0][0], mirrorCoord[0][1]] = 'A';
                            currentX = mirrorCoord[0][0];
                            currentY = mirrorCoord[0][1];
                        }
                    } 
                    else
                    {
                        if (Char.IsNumber(armory[(currentX + 1), currentY]))
                        {
                            //Buys Sword
                            profit += int.Parse(armory[(currentX + 1), currentY].ToString());
                        }
                        //Just Moves
                        armory[currentX, currentY] = '-';
                        armory[currentX + 1, currentY] = 'A';
                        currentX++;
                    }
                }
                else if(command == "left")
                {
                    if (currentY - 1 < 0)
                    {
                        //Leaves the Armory
                        Console.WriteLine("I do not need more swords!");
                        Console.WriteLine($"The king paid {profit} gold coins.");
                        armory[currentX, currentY] = '-';
                        break;

                    }
                    else if (armory[currentX, currentY - 1] == 'M')
                    {
                        //Teleport to the other mirror
                        if ((currentX - 1 == mirrorCoord[0][0]) && currentY == mirrorCoord[0][1])
                        {
                            armory[currentX, currentY - 1] = '-';
                            armory[currentX, currentY] = '-';
                            armory[mirrorCoord[1][0], mirrorCoord[1][1]] = 'A';
                            currentX = mirrorCoord[1][0];
                            currentY = mirrorCoord[1][1];
                        }
                        else
                        {
                            armory[currentX, currentY - 1] = '-';
                            armory[currentX, currentY] = '-';
                            armory[mirrorCoord[0][0], mirrorCoord[0][1]] = 'A';
                            currentX = mirrorCoord[0][0];
                            currentY = mirrorCoord[0][1];
                        }
                    }
                    else
                    {
                        if (Char.IsNumber(armory[currentX, currentY - 1]))
                        {
                            //Buys Sword
                            profit += int.Parse(armory[currentX, currentY-1].ToString());
                        }
                        //Just moves
                        armory[currentX, currentY] = '-';
                        armory[currentX, currentY -1] = 'A';
                        currentY--;
                    }
                }
                else if(command == "right")
                {
                    if (currentY + 1 >= n)
                    {
                        //Leaves the Armory
                        Console.WriteLine("I do not need more swords!");
                        Console.WriteLine($"The king paid {profit} gold coins.");
                        armory[currentX, currentY] = '-';
                        break;
                    }
                    else if (armory[currentX, currentY + 1] == 'M')
                    {
                        //Teleport to the other mirror
                        if ((currentX - 1 == mirrorCoord[0][0]) && currentY == mirrorCoord[0][1])
                        {
                            armory[currentX, currentY + 1] = '-';
                            armory[currentX, currentY] = '-';
                            armory[mirrorCoord[1][0], mirrorCoord[1][1]] = 'A';
                            currentX = mirrorCoord[1][0];
                            currentY = mirrorCoord[1][1];
                        }
                        else
                        {
                            armory[currentX, currentY + 1] = '-';
                            armory[currentX, currentY] = '-';
                            armory[mirrorCoord[0][0], mirrorCoord[0][1]] = 'A';
                            currentX = mirrorCoord[0][0];
                            currentY = mirrorCoord[0][1];
                        }
                    }
                    else
                    {
                        if (Char.IsNumber(armory[currentX, currentY + 1]))
                        {
                            profit += int.Parse(armory[currentX, currentY + 1].ToString());
                            //Buys Sword
                        }
                        //Just Moves
                        armory[currentX, currentY] = '-';
                        armory[currentX, currentY + 1] = 'A';
                        currentY++;
                    }
                }
            }

            if(profit >= 65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
                Console.WriteLine($"The king paid {profit} gold coins.");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(armory[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
