namespace DigitsCountApp
{
    /// <summary>
    /// counts the number of digits of an integer
    /// for example 123 has 3
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");

            if(!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Error");
                return;
            }

            if(number == 0)
            {
                Console.WriteLine("number of digits cannot be 1");
                return;
            }

            int digitCount = 0;
            while(number > 0)
            {
                number /= 10;
                digitCount++;
            }

            Console.WriteLine($"Number of digits : {digitCount}");
        }
    }
}
