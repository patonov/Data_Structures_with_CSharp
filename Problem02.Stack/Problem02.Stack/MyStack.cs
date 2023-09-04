namespace Problem02.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyStack<T> : IAbstractStack<T>
    {
        private class Node
        {
            public T Element { get; set; }
            public Node Next { get; set; }

            public Node(T element, Node next)
            {
                this.Element = element;
                this.Next = next;
            }

            public Node(T element)
            {
                this.Element = element;
            }
        }

        private Node top;

        public MyStack()
        {
            this.top = null;
            this.Count = 0;
        }

        public int Count { get; private set; }

        public void Push(T item)
        {
            Node node = new Node(item);
            node.Next = this.top;
            this.top = node;
            this.Count++;
        }

        public T Pop()
        {
            this.ValidateNotEmpty();

            T item = this.top.Element;
            this.top = this.top.Next;
            this.Count--;

            return item;
        }

        public T Peek()
        {
            this.ValidateNotEmpty();

            return this.top.Element;
        }

        public bool Contains(T item)
        {
            Node current = this.top;

            while (current != null)
            {
                if (current.Element.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        private void ValidateNotEmpty()
        {
            if (this.top == null)
            {
                throw new InvalidOperationException("The stack is empty!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = this.top;

            while (current != null)
            {
                yield return current.Element;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}