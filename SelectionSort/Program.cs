namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 11, 2, 33, 14, 5, 68, 29,};
            int minPosition;
            int min;

            for(int i = 0; i < arr.Length; i++)
            {
                minPosition = i;
                min = arr[minPosition];

                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[j] < min)
                    {
                        minPosition = j;
                        min = arr[j];
                    }
                }

                Swap(arr, i, minPosition);

            }

            foreach(int item in arr)
            {
                Console.WriteLine(item + " ");
            }

        }

        public static void Swap(int[] arr, int i, int j)
        {
            (arr[j], arr[i]) = (arr[i], arr[j]);
        }
    }
}
