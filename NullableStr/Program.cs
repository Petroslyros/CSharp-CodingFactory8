namespace NullableStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = null!;       //non-nullable warning
            string? s2 = null;      //nullable

            s1 = Console.ReadLine()!;
            s2 = Console.ReadLine();

            if(s1.Equals("Coding") && s2!.Equals("Coding"))
            {
                Console.WriteLine("Bingo");
            }

        }
    }
}
