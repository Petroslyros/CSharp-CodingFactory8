namespace ArrMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 15, 25, 12, 55 };
            int minPosition = 0;

            getArrMin(ages,ref minPosition);

            Console.WriteLine($"Min Val : {ages[minPosition]}, min position : {minPosition + 1}");

        }

        public static void getArrMin(int[] ages,ref int minPosition)
        {
            for(int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < ages[minPosition])
                {
                    minPosition = i;
                }
            }
        }
    }
}
