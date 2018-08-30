using System;

namespace ReadifyTestServices
{
    public class FibonacciService : IFibonacciService
    {
        /// <summary>
        /// Computes nth number from the fibonacci sequence. See http://mathworld.wolfram.com/BinetsFibonacciNumberFormula.html
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>The nth number of the Fibonacci sequence</returns>
        public long ComputeFibonacci(int n)
        {
            var numerator = Math.Pow((1.0 + Math.Sqrt(5.0)), n)
                            - Math.Pow((1.0 - Math.Sqrt(5.0)), n);
            var denominator = Math.Pow(2.0, n) * Math.Sqrt(5.0);
            var result = numerator / denominator;

            var rounded = Math.Round(result);

            return (long)rounded;
        }
    }
}
