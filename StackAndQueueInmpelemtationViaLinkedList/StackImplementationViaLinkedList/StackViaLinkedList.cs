using System;
using System.Collections.Generic;
using System.Text;
using LinkedListSimpleImplementation;

namespace LinkedListSimpleImplementation
{
    public class StackViaLinkedList<T>
    {
        private LinkedList<T> linkedList;

        public StackViaLinkedList()
        {
            linkedList = new LinkedList<T>();
        }

        public int Count { get { return linkedList.Count; } }

        public void Push(T element)
        {
            linkedList.Add(element);
        }

        public T Peek()
        {
            return linkedList.Head.Value;
        }

        public T Pop()
        {
            return linkedList.RemoveHead().Value;
        }
    }
}
