using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSortOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine("Before Sorting:");
            foreach (var n in nums)
            {
                Console.WriteLine(n);

            }
            Console.WriteLine();

            Console.WriteLine("After Sorting:");
            Array.Sort(nums);

            foreach (var n in nums)
            {
                Console.WriteLine(n);

            }
            Console.WriteLine();
        }
    }
}
