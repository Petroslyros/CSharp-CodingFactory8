namespace IgnoreNegativesApp
{
    /// <summary>
    /// Counts the sum of positives
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Please input an integer : ");
            
            if(!int.TryParse(Console.ReadLine(), out int num))
             {
                Console.WriteLine("Wrong input");
                return;
            }

            while(num >= 0)
            {
               if(num > 0) count++;

                Console.WriteLine("Please input an integer : ");
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Wrong input");
                    return;
                }
            }

            Console.WriteLine($"The count of positives is {count}");
        }
    }
}
