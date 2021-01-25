using System;
using static System.Console;

namespace SalesLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayContactInfo("phone");
            WriteLine("heading of a letter");
            WriteLine("body of a letter");
            WriteLine("conclusion of letter");
            DisplayContactInfo("email");
            DisplayContactInfo("address");
        }

        static void DisplayContactInfo(string type)
        {
            string phone = "Phone Number: 555-555-5555";
            string email = "Email: fakeEmail@aol.com";
            string address = "address: 555 roadname, state, country";
            
            switch (type)
            {
                case "phone":
                    WriteLine(phone);
                    break;
                case "email":
                    WriteLine(email);
                    break;
                case "address":
                    WriteLine(address);
                    break;
            }
        }
    }
}
