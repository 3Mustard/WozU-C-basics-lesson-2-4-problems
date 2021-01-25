using System;
using static System.Console;

namespace OverdueInvoices
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int numOfInvoices;
            int daysOverdue;
            string userInput;

            // get user input
            WriteLine("Enter the number of overdue invoices: ");
            userInput = ReadLine();
            int.TryParse(userInput, out numOfInvoices);
            WriteLine("Enter the number of days overdue: ");
            userInput = ReadLine();
            int.TryParse(userInput, out daysOverdue);

            DisplayLateFee(numOfInvoices, daysOverdue);
        }

        static void DisplayLateFee(int numOfInvoices, int daysOverdue)
        {
            string lateFee = GetLateFee(daysOverdue);
            WriteLine($"There are {numOfInvoices} overdue invoices.");
            WriteLine($"They are {daysOverdue} days overdue.");
            WriteLine($"The late fee is {lateFee} of the total bill.");
        }

        static string GetLateFee(int daysOverdue)
        {
            string lateFee = "10%";
            if (daysOverdue > 7)
            {
                int x = daysOverdue - 7;
                lateFee = $"{x * 20}%";
            }
            return lateFee;
        }
    }
}
