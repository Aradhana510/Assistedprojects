using System;

namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            string[] students = { "Alice", "Bob", "Charlie", "David", "Eva" };
            int currentIndex = 0;
            printViaRecursion(students, currentIndex);
        }

        static void printViaRecursion(string[] arr, int index)
        {
            // Base case: If the index goes out of bounds, return and stop the recursion.
            if (index >= arr.Length)
                return;

            // Print the name at the current index
            Console.WriteLine(arr[index]);

            // Call the method recursively with the next index
            printViaRecursion(arr, index + 1);
        }
    }
}
