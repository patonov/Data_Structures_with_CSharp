using System;

namespace SimpleBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = new int[10] { 2, 4, 6, 8, 9, 11, 13, 15, 18, 23 };

            int targetElement = int.Parse(Console.ReadLine());

            int elementPosition = Array.BinarySearch(input, targetElement);

            if (elementPosition >= 0)
            {
                Console.WriteLine($"Element {input[elementPosition].ToString()} was found at the following position {elementPosition + 1}.");
            }
            else
            {
                Console.WriteLine($"Element {targetElement} was not found");            
            }
        }
    }
}