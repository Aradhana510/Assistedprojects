using System;

class Program
{
    static void Main()
    {
        // Create instances of the classes and demonstrate the use of interfaces
        IPerson student = GetStudent();

        IPerson teacher = new Teacher
        {
            FirstName = "Veenu",
            LastName = "Joon",
            Age = 35,
            Address = "456 Teacher Avenue"
        };

        IPerson officeStaff = new OfficeStaff
        {
            FirstName = "Rishik",
            LastName = "Jain",
            Age = 28,
            Address = "789 Office Road"
        };

        // Now you can use these objects as IPerson instances, regardless of their actual class type
        DisplayPersonDetails(student);
        DisplayPersonDetails(teacher);
        DisplayPersonDetails(officeStaff);

        // Add any additional code to demonstrate the use of the classes and interface as needed.
    }

    private static Students GetStudent()
    {
        return new Students
        {
            FirstName = "Aman",
            LastName = "Singh",
            Age = 20,
            Address = "123 Student Street"
        };
    }

    static void DisplayPersonDetails(IPerson person)
    {
        Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
        Console.WriteLine($"Age: {person.Age}");
        Console.WriteLine($"Address: {person.Address}");
        Console.WriteLine();
    }
}
