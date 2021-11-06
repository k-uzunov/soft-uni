using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace _1._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> author = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };



            AdvertismentMessage message = new AdvertismentMessage( phrases, events, author, cities);
            message.PrintMessage();
            
        }
    }

    class AdvertismentMessage
    {
        public List<string> Phrases { get; set; }
        public List<string> Events { get; set; }
        public List<string> Authors { get; set; }
        public List<string> Cities { get; set; }

        public AdvertismentMessage(List<string> phrases, List<string> events, List<string> authors, List<string> cities)
        {
            Phrases = phrases;
            Events = events;
            Authors = authors;
            Cities = cities;
        }

        public string RandomGenerator(List<string> text)
        {
            Random sentence = new Random();

            return text[sentence.Next(text.Count)];
        }

        public void PrintMessage()
        {
            Console.WriteLine($"{RandomGenerator(Phrases)} {RandomGenerator(Events)} {RandomGenerator(Authors)} - {RandomGenerator(Cities)}");
        }
    }
}
