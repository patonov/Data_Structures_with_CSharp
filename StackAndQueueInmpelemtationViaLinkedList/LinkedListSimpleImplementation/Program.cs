using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListSimpleImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> alreadyLinked = new LinkedList<int>();

            for (int i = 0; i <= 10; i++)
            {
                alreadyLinked.Add(i);
            }

            Console.WriteLine("Removed: {0}", alreadyLinked.RemoveHead().Value);

            for (int i = 1; i < 10; i++)
            {
                alreadyLinked.AddLast(i);
            }

            var currentNode = alreadyLinked.Head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }

            Console.WriteLine("Head is : {0}", alreadyLinked.Head.Value);
            Console.WriteLine("Last is : {0}", alreadyLinked.Last.Value);



        }
    }
}
