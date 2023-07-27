// SubjectTeacher.cs
using System;

class SubjectTeacher : IClassInfo, ITeacherInfo
{
    public string ClassName { get; set; }
    public int ClassId { get; set; }
    public string Name { get; set; }
    public string TeacherId { get; set; }
    public string Subject { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Class Name: {ClassName}, Class ID: {ClassId}");
        Console.WriteLine($"Teacher Name: {Name}, Teacher ID: {TeacherId}");
        Console.WriteLine($"Subject Taught: {Subject}");
    }
}
