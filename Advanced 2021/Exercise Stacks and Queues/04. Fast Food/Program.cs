using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] arrOrders = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int> { };

            foreach(int item in arrOrders)
            {
                orders.Enqueue(item);
            }

            Console.WriteLine(orders.Max());

            while (true)
            {
                if (orders.Count() == 0)
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
                else
                {
                    if (foodQuantity >= orders.Peek())
                    {
                        foodQuantity -= orders.Peek();
                        orders.Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("Orders left: {0}", String.Join(" ", orders));
                        break;
                    }
                    
                }
            }


           
        }
    }
}
