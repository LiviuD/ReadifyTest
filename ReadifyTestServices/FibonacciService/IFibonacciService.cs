namespace ReadifyTestServices
{
    public interface IFibonacciService : IReadifyTestService
    {
        /// <summary>
        /// Computes nth number from the fibonacci sequence. See http://mathworld.wolfram.com/BinetsFibonacciNumberFormula.html
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>The nth number of the Fibonacci sequence</returns>
        long ComputeFibonacci(int n);
    }
}