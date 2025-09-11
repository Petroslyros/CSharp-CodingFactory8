namespace Turnary
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Please input an integer");

            if(!int.TryParse(Console.ReadLine(), out int inputNum))
            {
                Console.WriteLine("Error during read");
                return;
            }

            Console.WriteLine("The abs of {0} = {1}", inputNum, (inputNum >= 0) ? inputNum : -inputNum);

        }
    }
}
