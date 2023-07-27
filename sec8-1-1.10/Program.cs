using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        runApp();
    }

    static void runApp()
    {
        Stack myStack = new Stack();

        Console.WriteLine("Pushing elements into the stack:");
        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);
        myStack.Push(40);

        Console.WriteLine("Stack is empty: " + myStack.IsEmpty());
        Console.WriteLine("Top element: " + myStack.Peek());

        Console.WriteLine("All elements in the stack:");
        List<int> elements = myStack.GetElements();
        foreach (int element in elements)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("Popping elements from the stack:");
        while (!myStack.IsEmpty())
        {
            Console.WriteLine("Popped: " + myStack.Pop());
        }

        Console.WriteLine("Stack is empty: " + myStack.IsEmpty());
    }
}
