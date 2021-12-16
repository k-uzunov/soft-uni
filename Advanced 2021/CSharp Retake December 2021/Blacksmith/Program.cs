using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Queue<int> steel = new Queue<int>(input);
            input.Clear();
            input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Stack<int> carbon = new Stack<int>(input);

            int totalNumberOfSwords = 0;
            Dictionary<string, int> forgedSwords = new Dictionary<string, int> { };

            while(steel.Any() && carbon.Any())
            {
                int firstSteel = steel.Peek();
                int lastCarbon = carbon.Peek();
                int mix = firstSteel + lastCarbon;

                switch (mix)
                {
                    case 70:
                        //Gladius
                        totalNumberOfSwords++;
                        if (forgedSwords.ContainsKey("Gladuis"))
                            forgedSwords["Gladuis"]++;
                        else
                            forgedSwords.Add("Gladius", 1);
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    case 80:
                        //Shamshir
                        totalNumberOfSwords++;
                        if (forgedSwords.ContainsKey("Shamshir"))
                            forgedSwords["Shamshir"]++;
                        else
                            forgedSwords.Add("Shamshir", 1);
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    case 90:
                        //Katana
                        totalNumberOfSwords++;
                        if (forgedSwords.ContainsKey("Katana"))
                            forgedSwords["Katana"]++;
                        else
                            forgedSwords.Add("Katana", 1);
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    case 110:
                        //Sabre
                        totalNumberOfSwords++;
                        if (forgedSwords.ContainsKey("Sabre"))
                            forgedSwords["Sabre"]++;
                        else
                            forgedSwords.Add("Sabre", 1);
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    case 150:
                        //Broadsword
                        totalNumberOfSwords++;
                        if (forgedSwords.ContainsKey("Broadsword"))
                            forgedSwords["Broadsword"]++;
                        else
                            forgedSwords.Add("Broadsword", 1);
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    default:
                        steel.Dequeue();
                        carbon.Pop();
                        carbon.Push(lastCarbon + 5);
                        break;
                }
            }

            if (forgedSwords.Any())
                Console.WriteLine($"You have forged {totalNumberOfSwords} swords.");
            else
                Console.WriteLine("You did not have enough resources to forge a sword.");

            if (steel.Any())
            {
                List<int> steelLeft = steel.ToList();
                Console.WriteLine($"Steel left: {string.Join(", ", steelLeft)}");
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }

            if (carbon.Any())
            {
                List<int> carbonLeft = carbon.ToList();
                Console.WriteLine($"Carbon left: {string.Join(", ", carbonLeft)}");
            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }

            forgedSwords = forgedSwords.OrderBy(x => x.Key).ToDictionary(x =>x.Key, y => y.Value);
            foreach(string sword in forgedSwords.Keys)
            {
                Console.WriteLine("{0}: {1}", sword, forgedSwords[sword]);
            }
        }
    }
}
