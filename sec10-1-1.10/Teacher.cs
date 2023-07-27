// Teacher.cs
using System;

class Teacher : ITeacherInfo
{
    public string Name { get; set; }
    public string TeacherId { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Teacher Name: {Name}, Teacher ID: {TeacherId}");
    }
}
