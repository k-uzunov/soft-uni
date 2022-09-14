using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _9._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            while(pokemons.Count > 0)
            {
                int inputIndex = int.Parse(Console.ReadLine());

                    sum += capturePokemon(pokemons, inputIndex, sum);
            }
            Console.WriteLine(sum);
        }

        static int capturePokemon(List<int> elements, int index, int sum) {
            int element;

            if (index < 0)
            {
                element = elements[0];
                elements.RemoveAt(0);
                elements.Insert(0, elements[elements.Count - 1]);
            }
            else if (index >= elements.Count)
            {
                element = elements[elements.Count - 1];
                elements.RemoveAt(elements.Count - 1);
                elements.Add(elements[0]);
            }
            else
            {
                element = elements[index];
                elements.RemoveAt(index);
            }
            
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] <= element)
                {
                    elements[i] += element;
                }
                else
                {
                    elements[i] -= element;
                }
            }

            return element;
        }
    }
}
