using System;

namespace AssignmentApp
{
    class TicketPriceCalculator
    {
        public static void Run()
        {
            Console.Write("\nEnter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age) && age >= 0)
            {
                int price = (age <= 12 || age >= 65) ? 7 : 10;
                Console.WriteLine($"Ticket price: GHC{price}\n");
            }
            else
            {
                Console.WriteLine("Invalid age input.\n");
            }
        }
    }
}
