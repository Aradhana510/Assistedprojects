using System;

namespace DoublyLinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList();

            // Add nodes to the doubly linked list
            doubleLinkedList.AddNode(10);
            doubleLinkedList.AddNode(20);
            doubleLinkedList.AddNode(30);
            doubleLinkedList.AddNode(40);
            doubleLinkedList.AddNode(50);

            // Display the nodes in the doubly linked list
            Console.WriteLine("Doubly Linked List:");
            doubleLinkedList.DisplayNodes();
        }
    }
}
