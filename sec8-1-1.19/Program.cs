using System;

namespace BubbleSortDemo
{
    class Student
    {
        public string Name { get; set; }
        public int RollNumber { get; set; }
    }

    class Program
    {
        static void BubbleSort(Student[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].RollNumber > arr[j + 1].RollNumber)
                    {
                        // Swap the elements
                        Student temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintStudents(Student[] arr)
        {
            foreach (var student in arr)
            {
                Console.WriteLine($"{student.Name} - Roll Number: {student.RollNumber}");
            }
        }

        static void runApp()
        {
            Student[] students = new Student[]
            {
                new Student { Name = "John", RollNumber = 101 },
                new Student { Name = "Eve", RollNumber = 104 },
                new Student { Name = "Alice", RollNumber = 102 },
                new Student { Name = "Michael", RollNumber = 105 },
                new Student { Name = "Bob", RollNumber = 103 }
                
                
            };

            Console.WriteLine("Unsorted List of Students:");
            PrintStudents(students);

            BubbleSort(students);

            Console.WriteLine("\nSorted List of Students (by Roll Number):");
            PrintStudents(students);
        }

        static void Main(string[] args)
        {
            runApp();
        }
    }
}
