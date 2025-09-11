namespace ArraysApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int[] arr2 = new int[] { 1, 2, 3 };
            int[] arr3 = { 1, 2, 3 };

            arr[0] = 0;
            arr2[1] = 5;

            Console.WriteLine($"{arr[2]}");
            Console.WriteLine($"Arr[2] = {arr[2]}");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            foreach (int el in arr2)
            {
                Console.WriteLine(el);
            }
             


        }
    }
}
