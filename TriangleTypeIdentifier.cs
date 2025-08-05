using System;

namespace AssignmentApp
{
    class TriangleTypeIdentifier
    {
        public static void Run()
        {
            Console.WriteLine("\nEnter lengths of the three sides:");

            Console.Write("Side 1: ");
            bool s1Valid = double.TryParse(Console.ReadLine(), out double s1);

            Console.Write("Side 2: ");
            bool s2Valid = double.TryParse(Console.ReadLine(), out double s2);

            Console.Write("Side 3: ");
            bool s3Valid = double.TryParse(Console.ReadLine(), out double s3);

            if (s1Valid && s2Valid && s3Valid && s1 > 0 && s2 > 0 && s3 > 0)
            {
                if (s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1) // Triangle inequality
                {
                    if (s1 == s2 && s2 == s3)
                        Console.WriteLine("Triangle type: Equilateral\n");
                    else if (s1 == s2 || s1 == s3 || s2 == s3)
                        Console.WriteLine("Triangle type: Isosceles\n");
                    else
                        Console.WriteLine("Triangle type: Scalene\n");
                }
                else
                {
                    Console.WriteLine("The sides do not form a valid triangle.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Enter positive numbers.\n");
            }
        }
    }
}
