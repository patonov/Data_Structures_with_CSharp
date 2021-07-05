using System;
using System.Collections;
using System.Collections.Generic;

namespace MySimpleStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> mySimpleStack = new Stack<string>();
            mySimpleStack.Push("Hello");
            mySimpleStack.Push("World");
            mySimpleStack.Push("!");

            Console.WriteLine("mySimpleStack:");
            Console.WriteLine("\t* Count:    {0}", mySimpleStack.Count);
            Console.Write("\t* Values:");

            StackPrinter(mySimpleStack);
        }
        public static void StackPrinter(IEnumerable mySimpleStack)
        {
            foreach (var element in mySimpleStack)
            {
                Console.Write("    {0}", element);
            }

            Console.WriteLine();
        }
    
    }
}
