using System;

namespace ControlFlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the doApp() method to demonstrate control flow
            doApp();
        }

        static void doApp()
        {
            // Control flow examples

            // 1. If-else statement
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number == 0)
            {
                Console.WriteLine("The number is zero.");
            }
            else
            {
                Console.WriteLine("The number is negative.");
            }

            // 2. Switch statement
            char grade = 'A';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good job!");
                    break;
                case 'C':
                    Console.WriteLine("Keep it up!");
                    break;
                default:
                    Console.WriteLine("Work harder!");
                    break;
            }

            // 3. While loop
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("While loop iteration: " + i);
                i++;
            }

            // 4. For loop
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine("For loop iteration: " + j);
            }

            // 5. Do-while loop
            int k = 1;
            do
            {
                Console.WriteLine("Do-While loop iteration: " + k);
                k++;
            } while (k <= 5);

            // 6. Break statement
            for (int n = 1; n <= 10; n++)
            {
                Console.WriteLine(n);
                if (n == 5)
                {
                    Console.WriteLine("Reached 5, breaking the loop.");
                    break;
                }
            }

            // 7. Continue statement
            for (int m = 1; m <= 5; m++)
            {
                if (m == 3)
                {
                    Console.WriteLine("Skipping iteration 3 using continue.");
                    continue;
                }
                Console.WriteLine("Continue loop iteration: " + m);
            }
        }
    }
}
