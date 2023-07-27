public class Stack
{
    private Node top;

    public Stack()
    {
        top = null;
    }

    public void Push(int data)
    {
        Node newNode = new Node(data);
        if (top == null)
        {
            top = newNode;
        }
        else
        {
            newNode.Next = top;
            top = newNode;
        }
    }

    public int Pop()
    {
        if (top == null)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        int data = top.Data;
        top = top.Next;
        return data;
    }

    public int Peek()
    {
        if (top == null)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return top.Data;
    }

    public bool IsEmpty()
    {
        return top == null;
    }

    internal List<int> Elements => throw new NotImplementedException();

    public List<int> GetElements()
    {
        List<int> elements = new List<int>();
        Node current = top;

        while (current != null)
        {
            elements.Add(current.Data);
            current = current.Next;
        }

        return elements;
    }
}
