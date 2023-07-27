using System;

class HighSchoolGradeCard : GradeCard
{
    public int PhysicsScore { get; set; }
    public int ChemistryScore { get; set; }
    public int BiologyScore { get; set; }
    public int MathematicsScore { get; set; }

    public override void DisplayGradeCard()
    {
        base.DisplayGradeCard();
        Console.WriteLine($"Physics Score: {PhysicsScore}");
        Console.WriteLine($"Chemistry Score: {ChemistryScore}");
        Console.WriteLine($"Biology Score: {BiologyScore}");
        Console.WriteLine($"Mathematics Score: {MathematicsScore}");
        // Additional high school grade card details can be displayed here.
    }
}
