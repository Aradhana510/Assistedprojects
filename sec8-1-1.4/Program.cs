using System;

namespace StudentMarksArray
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            // Number of students
            int numStudents = 5;

            // Arrays to store students and marks
            string[] students = new string[numStudents];
            int[] marks = new int[numStudents];

            // Input student names and marks
            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter the name of student {i + 1}: ");
                students[i] = Console.ReadLine();

                Console.Write($"Enter the marks of student {i + 1}: ");
                int.TryParse(Console.ReadLine(), out marks[i]);
            }

            // Display the students and their marks
            Console.WriteLine("\nStudents and Marks:");
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"{students[i]}: {marks[i]}");
            }

            // Calculate and display the average marks
            double averageMarks = CalculateAverageMarks(marks);
            Console.WriteLine($"\nAverage Marks: {averageMarks}");
        }

        static double CalculateAverageMarks(int[] marks)
        {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }

            return (double)sum / marks.Length;
        }
    }
}
