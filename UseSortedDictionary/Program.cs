using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseSortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> initialSortedDict = new SortedDictionary<int, int>();

            for (int i = 0; i <= 10; i++)
            {
                initialSortedDict.Add(i, i + 2);
            }
            Console.WriteLine("The Initial SortedDictionary includes:");

            foreach (var kvp in initialSortedDict)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            Console.WriteLine();

            Console.WriteLine("The Initial SortedDictionary contains {0} elements.", initialSortedDict.Count);
            Console.WriteLine();

            if (initialSortedDict.ContainsKey(6) == true)
            {
                Console.WriteLine("The number 6 is available.");
            }
            else
            {
                Console.WriteLine("The number 6 is NOT available.");
            }
            Console.WriteLine();

            initialSortedDict.Remove(6);

            Console.Write("The Initial SortedDictionary contains {0} elements after removing the key whose number is 6.", initialSortedDict.Count);
            Console.WriteLine("These are: ");

            foreach (var kvp in initialSortedDict)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            Console.WriteLine();

            initialSortedDict.Clear();

            Console.WriteLine("The Initial SortedDictionary contains {0} elements after clearing.", initialSortedDict.Count);

        }
    }
}
