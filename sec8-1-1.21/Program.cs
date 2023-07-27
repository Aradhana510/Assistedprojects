using System;

namespace SelectionSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }

                // Swap the found minimum element with the first element
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void runApp()
        {
            int[] students = { 84, 67, 92, 75, 59, 91, 78, 82 };
            Console.WriteLine("Unsorted array:");
            PrintArray(students);

            SelectionSort(students);

            Console.WriteLine("Sorted array:");
            PrintArray(students);
        }
    }
}
