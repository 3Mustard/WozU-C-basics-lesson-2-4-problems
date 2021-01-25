using System;

namespace GreetingProject
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = Int32.Parse(GetInteger());
            int y = Int32.Parse(GetInteger());

            DisplaySum(x, y);
        }

        private static string GetInteger()
        {
            Console.WriteLine("Enter an integer: ");
            string x = Console.ReadLine();

            // if an integer isn't entered keep asking for one.
            while (!CheckInt(x))
            {
                x = GetInteger();
            }
            
            return x;
        }

        private static bool CheckInt(string x)
        {
            try
            {
                Int32.Parse(x);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private static void DisplaySum(int x, int y)
        {
            Console.WriteLine($"the sum of both integers is {x + y}");
        }

    }
}
