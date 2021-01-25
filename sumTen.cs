using System;

namespace lesson3_9P
{
    class SumTenints
    {
        static void Main(string[] args)
        {
            int[] userData = GetData();
            int sum = SumValues(userData);
            DisplayData(sum.ToString());
        }

        static int[] GetData()
        {
            int[] userData = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter an integer");
                string userInput = Console.ReadLine();
                int parsedValue;
                if (!Int32.TryParse(userInput, out parsedValue))
                {
                    Console.WriteLine("Integers only please try again.");
                    Environment.Exit(1);
                }
                else
                {
                    userData[i] = parsedValue;
                }
            }
            return userData;
        }

        static int SumValues(int[] values)
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += values[i];
            }
            return total;
        }

        static void DisplayData(string data)
        {
            Console.WriteLine($"The total of all integers entered is: {data}");
        }
    }
}

