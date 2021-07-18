using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> initialSortedSet = new SortedSet<int>();

            for (int i = 0; i <= 10; i++)
            {
                initialSortedSet.Add(i);
            }
            Console.WriteLine("The Initial SortedSet includes:");

            foreach (var element in initialSortedSet)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The Initial SortedSet contains {0} elements.", initialSortedSet.Count);
            Console.WriteLine();

            if (initialSortedSet.Contains(2) == true)
            {
                Console.WriteLine("The number 2 is available.");
            }
            else
            {
                Console.WriteLine("The number 2 is NOT available.");
            }
            Console.WriteLine();

            initialSortedSet.RemoveWhere(n => n % 2 == 0);

            Console.Write("The Initial SortedSet contains {0} elements after removing the even numbers.", initialSortedSet.Count);
            Console.Write("These are: ");

            foreach (var element in initialSortedSet)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            initialSortedSet.Clear();

            Console.WriteLine("The Initial SortedSet contains {0} elements after clearing.", initialSortedSet.Count);
        }
    }
}
