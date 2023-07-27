using System;

namespace LinearSearchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            // Create an array of integers (you can modify this to search for other types of values).
            int[] arr = { 10, 5, 3, 8, 2, 7, 1, 6, 4, 9 };

            // Get the value to be searched from the user.
            Console.Write("Enter the value to search for: ");
            if (int.TryParse(Console.ReadLine(), out int searchValue))
            {
                // Perform the linear search.
                int index = LinearSearch(arr, searchValue);

                // Display the result of the search.
                if (index != -1)
                {
                    Console.WriteLine($"The value {searchValue} was found at index {index}.");
                }
                else
                {
                    Console.WriteLine($"The value {searchValue} was not found in the array.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.ReadLine();
        }

        static int LinearSearch(int[] arr, int searchValue)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchValue)
                {
                    return i; // Return the index where the value is found.
                }
            }
            return -1; // Return -1 if the value is not found in the array.
        }
    }
}
