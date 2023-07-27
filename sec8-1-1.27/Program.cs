using System;

namespace ShellSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            // Sample array of marks (replace this with your own marks)
            int[] marks = { 78, 85, 92, 64, 55, 70, 80, 68, 88, 90 };

            Console.WriteLine("Marks before sorting:");
            PrintArray(marks);

            // Perform Shell Sort
            ShellSort(marks);

            Console.WriteLine("\nMarks after sorting in ascending order:");
            PrintArray(marks);
        }

        private static void ShellSort(int[] arr)
        {
            int n = arr.Length;
            int gap;

            for (gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
        }

        private static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
