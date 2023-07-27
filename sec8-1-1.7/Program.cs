using System;

namespace SinglyLinkedListDemo
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }


    public class SingleLinkedList
    {
        private Node head;

        public SingleLinkedList()
        {
            head = null;
        }

        public void InsertFront(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void DisplayList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            SingleLinkedList myList = new SingleLinkedList();

            // Insert elements into the linked list
            myList.InsertFront(3);
            myList.InsertFront(5);
            myList.InsertFront(7);
            myList.InsertFront(9);

            // Display the linked list
            Console.WriteLine("Linked List: ");
            myList.DisplayList();
        }
    }
}
