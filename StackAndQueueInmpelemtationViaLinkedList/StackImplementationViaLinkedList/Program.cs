using System;
using System.Collections.Generic;
using System.Text;
using LinkedListSimpleImplementation;
using StackImplementationViaLinkedList;

namespace StackImplementationViaLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackViaLinkedList<int> viaLinkedList = new StackViaLinkedList<int>();
            int i = 7;
            viaLinkedList.Push(i);
            viaLinkedList.Push(i * 2);
            viaLinkedList.Push(i * 3);

            Console.WriteLine(viaLinkedList.Peek());

            Console.WriteLine(viaLinkedList.Pop());
        }
    }
}
