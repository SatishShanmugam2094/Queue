using System;

namespace CustomQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("Printing values after adding in queue");
            queue.Print();
            Console.WriteLine("Printing values after deleting in queue");
            Console.WriteLine("The value dequeued is {0}", queue.Dequeue());
            queue.Print();
            Console.WriteLine("Printing the first element in queue");
            Console.WriteLine("The value on first is {0}", queue.Peek());
            Console.Read();
        }
    }
}
