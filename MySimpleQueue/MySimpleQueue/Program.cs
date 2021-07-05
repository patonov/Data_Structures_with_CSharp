using System;
using System.Collections;
using System.Collections.Generic;

namespace MySimpleQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> mySimpleQueue = new Queue<string>();
            mySimpleQueue.Enqueue("Hello");
            mySimpleQueue.Enqueue("World");
            mySimpleQueue.Enqueue("!");
            

            Console.WriteLine("mySimpleQueue:");
            Console.WriteLine("\t*Count:    {0}", mySimpleQueue.Count);
            Console.Write("\t*Values:");
            QueuePrinter(mySimpleQueue);
        }

        public static void QueuePrinter(IEnumerable mySimpleQueue)
        {
            foreach (var element in mySimpleQueue)
            {
                Console.Write("    {0}", element);
            }
            Console.WriteLine();
        }
    
    }
}
