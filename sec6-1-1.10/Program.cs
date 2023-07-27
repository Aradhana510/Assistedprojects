using System;
using System.Text;

namespace TextDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {
            // Using string
            string message = "Hello, this is a demonstration of working with text in C#.";
            Console.WriteLine(message);

            // Modifying strings
            string name = "John";
            string greeting = "Hello, " + name + "!"; // Concatenation using +
            Console.WriteLine(greeting);

            // Using StringBuilder for efficient string manipulation
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("This is line 1.");
            stringBuilder.AppendLine(); // Appends a new line
            stringBuilder.Append("This is line 2.");
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
