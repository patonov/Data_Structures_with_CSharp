using System;
using System.Linq;

namespace BinarySearchMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayForChecking = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < arrayForChecking.Length; i++)
            {
                if (arrayForChecking[i] < arrayForChecking[i - 1])
                {
                    Console.WriteLine("Binary searcher will not provide optimal result.");
                    return;
                }
            }

            Console.WriteLine(BinarySearcher(arrayForChecking, num));
        }


        public static bool BinarySearcher(int[] arrayForChecking, int num)
        {
            int minCount = 0;
            int maxCount = arrayForChecking.Length - 1;
            
            while (minCount <= maxCount)
            {
                int middleCount = (minCount + maxCount) / 2;
                
                if (num == arrayForChecking[middleCount])
                {
                    return true;
                }
                else if (num < arrayForChecking[middleCount])
                {
                    maxCount = middleCount - 1;
                }
                else
                {
                    minCount = middleCount + 1;
                }
            }
            return false;
        }
    }
}
