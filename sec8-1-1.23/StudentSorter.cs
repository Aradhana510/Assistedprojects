using System;

public static class StudentSorter
{
    public static void InsertionSort(Student[] students)
    {
        int n = students.Length;

        for (int i = 1; i < n; i++)
        {
            Student key = students[i];
            int j = i - 1;

            while (j >= 0 && students[j].Name.CompareTo(key.Name) > 0)
            {
                students[j + 1] = students[j];
                j = j - 1;
            }

            students[j + 1] = key;
        }
    }
}

public class Student
{
    public string Name { get; set; }
    // Add other properties of the student here, if needed.
}
