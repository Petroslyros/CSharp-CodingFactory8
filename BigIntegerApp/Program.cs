using System.Numerics;

namespace BigIntegerApp
{
    /// <summary>
    /// calculates the sum of 1*2*3*....n
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            BigInteger result = 1; // auto-boxing and overloading of = for big integers
            int i = 1;

            while (i <= n)
            {
                result *= i;
                i++;
            }

            Console.WriteLine($"1 * 2 * 3 * ... * {n} = {result:N0}");
        }
    }
}
