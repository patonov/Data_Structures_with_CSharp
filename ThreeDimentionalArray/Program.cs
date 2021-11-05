using System;
using System.Linq;
using System.Collections.Generic;

namespace ThreeDimentionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[,,] arr = new int[2, 2, 4] { { { 1, 2, 3, 41 }, { 4, 5, 6, 71} }, { { 13, 8, 9, 16 }, { 10, 11, 12, 99 } } };

            
            Console.WriteLine("The 3D-array started with {0}.", arr[0, 0, 0]);
         
            Console.WriteLine("The 3D-array is long {0} characters.", arr.Length);
            
            decimal sum = 0;

            foreach (int a in arr)
            {
                sum += a; 
            }

            Console.WriteLine("Total amount of 3D-array's values is {0}.", sum);
        }
    }
}
