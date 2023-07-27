using System;

class Program
{
    static void Main()
    {
        runApp();
    }

    static void runApp()
    {
        // Create an array of students
        Student[] students = new Student[]
        {
            new Student { Name = "Bob" },
            new Student { Name = "Alice" },
            new Student { Name = "Eve" }
            
            
            // Add more students here if needed
        };

        Console.WriteLine("Unsorted List of Students:");
        PrintStudents(students);

        // Sort the array of students using Insertion Sort
        StudentSorter.InsertionSort(students);

        Console.WriteLine("\nSorted List of Students (by name):");
        PrintStudents(students);
    }

    static void PrintStudents(Student[] students)
    {
        foreach (var student in students)
        {
            Console.WriteLine(student.Name);
        }
    }
}
