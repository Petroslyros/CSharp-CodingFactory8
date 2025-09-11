namespace FormatExceptionApp
{
    internal class Program
    {
        /// <summary>
        /// reads an input string and tries to format to int 
        /// and checks with try catch with FormatException
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num;

            while (true)
            {
                try
                {
                    Console.WriteLine("Please input an integer number (0 to exit)");
                    num = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Your input is : {num}");
                    if (num == 0) break;
                } 
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
