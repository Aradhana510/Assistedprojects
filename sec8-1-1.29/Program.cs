using System;

namespace MergeSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            int[] marks = { 85, 92, 78, 90, 88, 95 };
            Console.WriteLine("Original marks:");
            PrintArray(marks);

            MergeSort.Sort(marks);

            Console.WriteLine("\nSorted marks in ascending order:");
            PrintArray(marks);
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
