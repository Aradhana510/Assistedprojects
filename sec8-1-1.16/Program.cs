using System;

namespace BinarySearchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            // Create a sorted array of integers (Binary Search requires a sorted array)
            int[] array = { 2, 5, 7, 10, 15, 20, 25, 30, 35, 40 };

            // Get the target value from the user
            Console.Write("Enter the target value to search in the array: ");
            int target = int.Parse(Console.ReadLine());

            // Call the Binary Search method and store the result
            int result = BinarySearch(array, target);

            // Check if the result is -1 (not found) or other index (found)
            if (result == -1)
            {
                Console.WriteLine("Element not found in the array.");
            }
            else
            {
                Console.WriteLine("Element found at index: " + result);
            }
        }

        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if the target is at the middle index
                if (array[mid] == target)
                {
                    return mid;
                }

                // If the target is less than the value at the middle index, search in the left half
                if (target < array[mid])
                {
                    right = mid - 1;
                }
                // If the target is greater than the value at the middle index, search in the right half
                else
                {
                    left = mid + 1;
                }
            }

            // If the element is not found in the array, return -1
            return -1;
        }
    }
}
