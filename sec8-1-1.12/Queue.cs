using System;

public class Queue<T>
{
    private T[] items;
    private int front;
    private int rear;
    private int size;
    private int count;

    public Queue(int size)
    {
        items = new T[size];
        front = 0;
        rear = -1;
        this.size = size;
        count = 0;
    }

    public void Enqueue(T item)
    {
        if (count == size)
        {
            Console.WriteLine("Queue is full. Cannot enqueue more items.");
            return;
        }

        rear = (rear + 1) % size;
        items[rear] = item;
        count++;
    }

    public T Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty. Cannot dequeue.");
            return default(T);
        }

        T item = items[front];
        front = (front + 1) % size;
        count--;
        return item;
    }

    public int Count => count;
}
