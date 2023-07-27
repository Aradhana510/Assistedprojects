// GradeCard.cs

using System;

class GradeCard
{
    public string StudentName { get; set; }
    public int RollNumber { get; set; }
    public string SchoolName { get; set; }

    public virtual void DisplayGradeCard()
    {
        Console.WriteLine("----- Grade Card -----");
        Console.WriteLine($"Student Name: {StudentName}");
        Console.WriteLine($"Roll Number: {RollNumber}");
        Console.WriteLine($"School Name: {SchoolName}");
        // Specific grade card details will be displayed in derived classes.
    }
}
