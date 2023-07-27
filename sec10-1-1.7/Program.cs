using System;

// Student class to store data about students
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

// Subject class to store data about subjects
public class Subject
{
    public string SubjectName { get; set; }
    public string TeacherName { get; set; }
}

// Teacher class to store data about teachers
public class Teacher
{
    public string Name { get; set; }
    public string Subject { get; set; }
}

// Class class to store data about classes
public class Class
{
    public string ClassName { get; set; }
    public Teacher ClassTeacher { get; set; }
    public List<Student> Students { get; set; }

    public Class()
    {
        Students = new List<Student>();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the classes and store data
        Student student1 = new Student { Name = "Veenu", Age = 18 };
        Student student2 = new Student { Name = "Rishik", Age = 17 };

        Subject math = new Subject { SubjectName = "Mathematics", TeacherName = "Mr. Sanjana" };
        Subject science = new Subject { SubjectName = "Science", TeacherName = "Mrs. Joseph" };

        Teacher teacher1 = new Teacher { Name = "Mr. Smith", Subject = "Mathematics" };
        Teacher teacher2 = new Teacher { Name = "Mrs. Johnson", Subject = "Science" };

        Class mathClass = new Class { ClassName = "Math Class", ClassTeacher = teacher1 };
        mathClass.Students.Add(student1);
        mathClass.Students.Add(student2);

        Class scienceClass = new Class { ClassName = "Science Class", ClassTeacher = teacher2 };
        scienceClass.Students.Add(student1);

        // Display the information
        Console.WriteLine("Math Class:");
        Console.WriteLine("Class Teacher: " + mathClass.ClassTeacher.Name);
        Console.WriteLine("Students:");
        foreach (var student in mathClass.Students)
        {
            Console.WriteLine("- " + student.Name);
        }

        Console.WriteLine("\nScience Class:");
        Console.WriteLine("Class Teacher: " + scienceClass.ClassTeacher.Name);
        Console.WriteLine("Students:");
        foreach (var student in scienceClass.Students)
        {
            Console.WriteLine("- " + student.Name);
        }
    }
}
