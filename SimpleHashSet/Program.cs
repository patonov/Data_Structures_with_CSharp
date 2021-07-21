using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> simpleHashSet = new HashSet<string>();

            simpleHashSet.Add("Pesho");
            simpleHashSet.Add("Gosho");
            simpleHashSet.Add("Misho");
            simpleHashSet.Add("Gogi");

            Console.WriteLine("Simple HashSet has {0} elements", simpleHashSet.Count);

            if (simpleHashSet.Contains("Misho"))
            {
                simpleHashSet.Remove("Misho");
                Console.WriteLine("After removing Misho, Simple HashSet has {0} elements", simpleHashSet.Count);
            }

            simpleHashSet.Clear();
            Console.WriteLine("After all working we've done, we are clearing the Simple HashSet and thus it has {0}", simpleHashSet.Count);

        }
    }
}
