using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSortedListOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, int> sortedListOfInts = new SortedList<int, int>();
            sortedListOfInts.Add(1, 0);
            sortedListOfInts.Add(2, 0);
            sortedListOfInts.Add(3, 0);
            sortedListOfInts.Add(10, 0);
            sortedListOfInts.Add(9, 0);
            sortedListOfInts.Add(8, 0);
            sortedListOfInts.Add(7, 0);
            sortedListOfInts.Add(6, 0);
            sortedListOfInts.Add(5, 0);
            sortedListOfInts.Add(4, 0);

            Console.WriteLine("Count: {0}", sortedListOfInts.Count);
            Console.WriteLine("Capacity: {0}", sortedListOfInts.Capacity);
            Console.WriteLine("Keys and values are:");


            foreach (var kvp in sortedListOfInts)
            {
                Console.WriteLine("{0}:{1}", kvp.Key, kvp.Value);
            }
        }
    }
}
