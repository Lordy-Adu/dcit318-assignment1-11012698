using System;

namespace AssignmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        GradeCalculator.Run();
                        break;
                    case "2":
                        TicketPriceCalculator.Run();
                        break;
                    case "3":
                        TriangleTypeIdentifier.Run();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.\n");
                        break;
                }
            }
        }
    }
}
