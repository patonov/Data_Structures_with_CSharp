using System;
using System.Collections.Generic;
using System.Text;
using LinkedListSimpleImplementation;

namespace LinkedListSimpleImplementation
{
    public class QueueViaLinkedList<T>
    {
        private LinkedListSimpleImplementation.LinkedList<T> linkedList;

        public QueueViaLinkedList()
        {
            linkedList = new LinkedListSimpleImplementation.LinkedList<T>();
        } 

        public int Count { get { return linkedList.Count; } }

        public void Enqueue(T element)
        {
            linkedList.AddLast(element);
        }

        public T Peek()
        {
            return linkedList.Head.Value;
        }

        public T Dequeue() 
        { 
            return linkedList.RemoveHead().Value;
        }

    }
}
