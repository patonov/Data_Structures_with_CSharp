using System;
using System.Text;
using System.Collections.Generic;

namespace SimpleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Console.WriteLine("Please write one of the following commands:");
            Console.WriteLine("Add {word} =>> Add word.");
            Console.WriteLine("Move First =>> Move first word to the end of the list.");
            Console.WriteLine("Move Last =>> Move last word to the beginning of the list.");
            Console.WriteLine("Change First {word} =>> Change first word.");
            Console.WriteLine("Change Last {word} =>> Change last word.");
            Console.WriteLine("Add After {new word} {existing word} =>> Add a new word after a workd in the list.");

            string[] command = Console.ReadLine().Split();

            LinkedList<string> lList = new LinkedList<string>(words);

            DisplayList(lList, "The linked list looks like:");
            Console.WriteLine();

            if (command[0] == "Add" && command.Length == 2)
            {
                lList.AddFirst(command[1]);
                string message = "The word " + command[1] + " was successfully added to beginning of the list:";
                DisplayList(lList, message);
            }
            else if (command[0] == "Move")
            {
                if (command[1] == "First")
                {
                    LinkedListNode<string> firstWord = lList.First;
                    lList.RemoveFirst();
                    lList.AddLast(firstWord);
                    string message = "First word has been successfully moved to the last position:";
                    DisplayList(lList, message);
                }
                else if (command[1] == "Last")
                {
                    LinkedListNode<string> lastWord = lList.Last;
                    lList.RemoveLast();
                    lList.AddFirst(lastWord);
                    string message = "Last word has been successfully moved to the first position:";
                    DisplayList(lList, message);
                }
            }
            else if (command[0] == "Change")
            {
                if (command[1] == "First")
                {
                    lList.RemoveFirst();
                    lList.AddFirst(command[2]);
                    string message = "First word has been successfully changed to " + command[1] + ":";
                    DisplayList(lList, message);
                }
                else if (command[1] == "Last")
                {
                    lList.RemoveLast();
                    lList.AddLast(command[2]);
                    string message = "Last word has been successfully changed to " + command[1] + ":";
                    DisplayList(lList, message);
                }
            }
            else if (command[0] == "Add" && command.Length == 4)
            {
                LinkedListNode<string> currentNode = lList.FindLast(command[3]);
                string message = "Last occurence of " + command[3];
                ShowNode(currentNode, message);

                lList.AddAfter(currentNode, command[2]);
                string newMessage = command[2] + " successfully added after " + command[3];
                ShowNode(currentNode, message);
            }

            Console.WriteLine();

            string[] finaleArray = new string[lList.Count];
            lList.CopyTo(finaleArray, 0);

            Console.WriteLine("LinkedList was read as an array:");
            foreach (string element in finaleArray)
            {
                Console.WriteLine(element);
            }

            lList.Clear();

        }

        private static void DisplayList(LinkedList<string> lList, string message)
        {
            Console.WriteLine(message);

            foreach (string node in lList)
            {
                Console.Write(node + " ");
            }

            Console.WriteLine();
        }

        private static void ShowNode(LinkedListNode<string> node, string message)
        {
            Console.WriteLine(message);

            if (node.List == null)
            {
                Console.WriteLine("This word is not in the list.\n");
                return;
            }

            StringBuilder result = new StringBuilder("(" + node.Value + ")");
            LinkedListNode<string> nodePrev = node.Previous;

            while (nodePrev != null)
            {
                result.Insert(0, nodePrev.Value + " ");
                nodePrev = nodePrev.Previous;
            }

            node = node.Next;

            while (node != null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
    
}
