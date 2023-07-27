using System;

namespace PrimitiveTypesAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the doApp() method to demonstrate primitive types and expressions
            doApp();

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void doApp()
        {
            // Primitive type variables
            int num1 = 10;
            double num2 = 5.5;
            char character = 'A';
            bool isTrue = true;

            // Expressions
            int sum = num1 + (int)num2; // Casting double to int before addition
            int product = num1 * (int)num2;
            bool isEqual = num1 == (int)num2;
            bool combinedExpression = (num1 > 5) && (num2 < 10);

            // Display the values and results
            Console.WriteLine($"num1: {num1}");
            Console.WriteLine($"num2: {num2}");
            Console.WriteLine($"character: {character}");
            Console.WriteLine($"isTrue: {isTrue}");
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"product: {product}");
            Console.WriteLine($"isEqual: {isEqual}");
            Console.WriteLine($"combinedExpression: {combinedExpression}");
        }
    }
}
