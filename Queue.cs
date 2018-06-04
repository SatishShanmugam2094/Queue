using System;

namespace CustomQueue
{
    public class Queue<T>
    {
        private Node<T> first = null;

        public Queue()
        {

        }

        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (first == null)
            {
                first = newNode;
                return;
            }
            Node<T> last = first;
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = newNode;
        }
        public void Dequeue()
        {
            if (first == null)
            {
                Console.WriteLine("The queue is empty");
                return;
            }
            Node<T> last = first;
            if (last != null)
            {
                first = last.next;
                last = null;
            }
        }
        public void Peek()
        {
            if (first == null)
            {
                Console.WriteLine("The queue is empty");
                return;
            }
            Console.WriteLine(first.item);
        }
        public void Print()
        {
            Node<T> element = first;
            while (element != null)
            {
                Console.WriteLine(element.item);
                element = element.next;
            }
        }
    }
}
