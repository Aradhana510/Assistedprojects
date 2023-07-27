using System;

namespace StudentDetails
{
    // Define the struct for storing student details
    public struct Student
    {
        public string Name;
        public int Age;
        public string Course;
    }

    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {
            // Create an instance of the Student struct
            Student student1;

            // Assign values to the struct fields
            student1.Name = "Veenu Joon";
            student1.Age = 20;
            student1.Course = "Computer Science";

            // Display student details
            Console.WriteLine("Student Details:");
            Console.WriteLine("Name: " + student1.Name);
            Console.WriteLine("Age: " + student1.Age);
            Console.WriteLine("Course: " + student1.Course);

            // You can create more instances of the Student struct and store different student details as needed.
        }
    }
}
