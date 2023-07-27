using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of SubjectTeacher and set its properties
            SubjectTeacher subjectTeacher = new SubjectTeacher
            {
                ClassName = "Math Class",
                ClassId = 101,
                Name = "Suarabh chaudhary",
                TeacherId = "T101",
                Subject = "Mathematics"
            };

            // Create an instance of ClassTeacher and set its properties
            ClassTeacher classTeacher = new ClassTeacher
            {
                ClassName = "Science Class",
                ClassId = 102,
                Name = "Shalini mehta",
                TeacherId = "T102",
                ClassNameHandled = "Science"
            };

            // Display information using the DisplayInfo methods of both classes
            Console.WriteLine("Subject Teacher Information:");
            subjectTeacher.DisplayInfo();

            Console.WriteLine("\nClass Teacher Information:");
            classTeacher.DisplayInfo();

            Console.ReadKey();
        }
    }
}
