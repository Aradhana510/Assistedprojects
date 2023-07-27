// CClass.cs
using System;

class CClass : IClassInfo
{
    public string ClassName { get; set; }
    public int ClassId { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Class Name: {ClassName}, Class ID: {ClassId}");
    }
}
