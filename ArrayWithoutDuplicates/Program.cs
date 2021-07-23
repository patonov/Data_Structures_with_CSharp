using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithoutDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = { 5, 5, 5, 12, 41, 55, 41, 11, 5 };
            int[] outputArr = inputArr.Distinct().ToArray();
            Array.Sort(outputArr);

            foreach (var n in outputArr)
            {
                Console.WriteLine(n);
            }
        }
    }
}
