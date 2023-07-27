using System;

class MiddleSchoolGradeCard : GradeCard
{
    public int MathScore { get; set; }
    public int ScienceScore { get; set; }
    public int SocialScienceScore { get; set; }

    public override void DisplayGradeCard()
    {
        base.DisplayGradeCard();
        Console.WriteLine($"Math Score: {MathScore}");
        Console.WriteLine($"Science Score: {ScienceScore}");
        Console.WriteLine($"Social Science Score: {SocialScienceScore}");
        // Additional middle school grade card details can be displayed here.
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}