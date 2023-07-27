public class DoubleLinkedList
{
    private Node head;
    private Node tail;

    public DoubleLinkedList()
    {
        head = null;
        tail = null;
    }

    public void AddNode(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }
    }

    public void DisplayNodes()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}
