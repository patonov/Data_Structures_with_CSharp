using System;

namespace BinomialCoefficientGenerating
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int result = 0;

            result = binomialCoefficientGenerator(n, k);

            Console.WriteLine("The value of C({0}, {1}) is {2}.", n, k, result);
        }

        private static int binomialCoefficientGenerator(int n, int k)
        {
            if (k > n)
            {
                return 0;
            }

            if (k == 0 || k == n)
            {
                return 1;
            }

            return binomialCoefficientGenerator(n - 1, k - 1) + binomialCoefficientGenerator(n - 1, k);
        }
    }
}
