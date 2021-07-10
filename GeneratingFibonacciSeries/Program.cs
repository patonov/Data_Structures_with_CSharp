using System;

namespace GeneratingFibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacciSeriesLength = int.Parse(Console.ReadLine());

            for (int i = 0; i < fibonacciSeriesLength; i++)
            {
                Console.Write("{0} ", FibonacciNumberGenerator(i));
            }
        }

        public static int FibonacciNumberGenerator(int n)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int result = 0;

            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            for (int i = 2; i <= n; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }
            return result;
        }
    }
}
