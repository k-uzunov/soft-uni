using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int intInput = int.Parse(Console.ReadLine());
                    DataType(intInput);
                    break;
                case "real":
                    double doubleInput = double.Parse(Console.ReadLine());
                    DataType(doubleInput);
                    break;
                case "string":
                    string stringInput = Console.ReadLine();
                    DataType(stringInput);
                    break;

            }
        }

        static void DataType(int input)
        {
            int result = input * 2;
            Console.WriteLine(result);
        }
        static void DataType(double input)
        {
            double result = input * 1.5;
            Console.WriteLine($"{result:F2}");
        }
        static void DataType(string input)
        {
            string result = "$" + input + "$";
            Console.WriteLine(result);
        }
        
    }
}
