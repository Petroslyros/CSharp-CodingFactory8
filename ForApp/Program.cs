namespace ForApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
           for(int i = 0; i < 10; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum is : {sum}");

            sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) continue;
                sum += i;
            }


            Console.WriteLine($"Sum of evens : {sum}");
        }
    }
}
