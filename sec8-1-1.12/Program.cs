using System;

namespace QueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            Queue<int> myQueue = new Queue<int>(5);

            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);

            Console.WriteLine($"Queue Count: {myQueue.Count}");

            int dequeuedItem = myQueue.Dequeue();
            Console.WriteLine($"Dequeued item: {dequeuedItem}");

            Console.WriteLine($"Queue Count after dequeue: {myQueue.Count}");

            // Enqueue more items to demonstrate wrapping behavior
            myQueue.Enqueue(40);
            myQueue.Enqueue(50);
            myQueue.Enqueue(60);

            Console.WriteLine($"Queue Count after wrapping: {myQueue.Count}");

            // Attempt to enqueue when the queue is full
            myQueue.Enqueue(70);

            Console.ReadKey();
        }
    }
}
