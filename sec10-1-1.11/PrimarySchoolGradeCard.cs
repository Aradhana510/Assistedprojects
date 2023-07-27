// PrimarySchoolGradeCard.cs

using System;

class PrimarySchoolGradeCard : GradeCard
{
    public int MathScore { get; set; }
    public int EnglishScore { get; set; }

    public override void DisplayGradeCard()
    {
        base.DisplayGradeCard();
        Console.WriteLine($"Math Score: {MathScore}");
        Console.WriteLine($"English Score: {EnglishScore}");
        // Additional primary school grade card details can be displayed here.
    }
}

