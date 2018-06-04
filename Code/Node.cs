namespace CustomQueue
{
    public class Node<T>
    {
        public Node<T> next = null;
        public T item;
        
        public Node(T value)
        {
            item = value;
        }
    }
}
