using System;
using System.Collections.Generic;
using System.Text;
using LinkedListSimpleImplementation;
using QueueImplementationViaLinkedList;

namespace QueueImplementationViaLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueViaLinkedList<int> queue = new QueueViaLinkedList<int>();

            int i = 9;
            queue.Enqueue(i);
            queue.Enqueue(i * 3);
            queue.Enqueue(i * 6);

            Console.WriteLine(queue.Peek());

            Console.WriteLine(queue.Dequeue());
        }
    }
}
