using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 12 || age >= 65)
            {
                Console.WriteLine("The ticket price is: GHC7");
            }
            else
            {
                Console.WriteLine("The ticket price is: GHC10");
            }
        }
    }
}
