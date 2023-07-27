// Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        // Test primary school grade card
        GradeCard primaryGradeCard = new PrimarySchoolGradeCard
        {
            StudentName = "Veenu Joon",
            RollNumber = 101,
            SchoolName = "ABC Primary School",
            MathScore = 90,
            EnglishScore = 85
        };
        primaryGradeCard.DisplayGradeCard();
        Console.WriteLine();

        // Test middle school grade card
        GradeCard middleGradeCard = new MiddleSchoolGradeCard
        {
            StudentName = "Rishik Jain",
            RollNumber = 201,
            SchoolName = "XYZ Middle School",
            MathScore = 88,
            ScienceScore = 82,
            SocialScienceScore = 90
        };
        middleGradeCard.DisplayGradeCard();
        Console.WriteLine();

        // Test high school grade card
        GradeCard highGradeCard = new HighSchoolGradeCard
        {
            StudentName = "Aman Singh",
            RollNumber = 301,
            SchoolName = "PQR High School",
            PhysicsScore = 95,
            ChemistryScore = 91,
            BiologyScore = 89,
            MathematicsScore = 93
        };
        highGradeCard.DisplayGradeCard();
    }
}
