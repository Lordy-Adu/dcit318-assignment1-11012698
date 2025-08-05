using System;

namespace AssignmentApp
{
    class GradeCalculator
    {
        public static void Run()
        {
            Console.Write("\nEnter grade (0 - 100): ");
            if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
            {
                char letterGrade = grade >= 90 ? 'A' :
                                   grade >= 80 ? 'B' :
                                   grade >= 70 ? 'C' :
                                   grade >= 60 ? 'D' : 'F';

                Console.WriteLine($"Letter grade: {letterGrade}\n");
            }
            else
            {
                Console.WriteLine("Invalid grade input.\n");
            }
        }
    }
}
