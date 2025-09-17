namespace LINQApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            

        }

        //query syntax -- Expression-bodied Members
        public static IEnumerable<int> GetAllNumbers(int[] numbers) => from num in numbers select num;

        //Method syntax
        public static IEnumerable<int> GetAllItems(int[] numbers) =>
            numbers.Select(num => num);
        
        //filtering == where
        public static int[] FilterToArray(int[] numbers)
        {
            //return [.. from num in numbers where (num % 2 == 0) select num]; //collection expression
            //return (from num in numbers where (num % 2 == 0) select num).ToArray();
            //Method syntax
            //return numbers.Where(num => num % 2 == 0).ToArray();
            return [.. numbers.Where(num => num % 2 == 0)];
        }

        public static int[] FilterToList(int[] numbers)
        {
           // return [.. from num in numbers where (num % 2 == 0) select num]; //collection expression
            //return (from num in numbers where (num % 2 == 0) select num).ToList();

            //Method syntax
            //return numbers.Where(num => num % 2 == 0).ToList();
            return [.. numbers.Where(num => num % 2 == 0)];
        }

        //mapping == select
        public static int[] MapOddToDoubleArray(int[] numbers)
        {
            return [.. from num in numbers where (num % 2 == 0) select num * 2]; 
            //return (from num in numbers where (num % 2 == 0) select num * 2).ToArray();
        }

        public static List<int> MapOddToDoubleList(int[] numbers)
        {
            //return [.. from num in numbers where (num % 2 == 0) select num * 2];
            //return (from num in numbers where (num % 2 == 0) select num * 2).ToList();

            return numbers.Where(n => n % 2 != 0).Select(n => n * 2).ToList();
        }

        //Reduction
        public static int SumAll(int[] numbers)
        {
            //return (from num in numbers select num).Sum();
            return numbers.Sum();

        }
        public static double AverageAll(int[] numbers)
        {
            //return (from num in numbers select num).Average();
           return numbers.Average();

        }
        public static int Count(int[] numbers)
        {
            //return (from num in numbers select num).Count();
            return numbers.Count();

        }
        public static int FindMin(int[] numbers)
        {
            //return (from num in numbers select num).Min();
            return numbers.Min();

        }
        public static int FindMax(int[] numbers)
        {
            //return (from num in numbers select num).Max();
            return numbers.Max();

        }

        public static int[] SortAsc(int[] numbers)
        {
            //return (from num in numbers orderby num ascending select num).ToArray();
            return numbers.OrderBy(n => n).ToArray();

        }
        public static int[] SortDesc(int[] numbers)
        {
            //return (from num in numbers orderby num descending select num).ToArray();
            return numbers.OrderByDescending(n => n).ToArray();

        }

        public static int[] ReverseArray(int[] numbers)
        {
            return numbers.Reverse().ToArray();
        }

        public static int[] DistinctArray(int[] numbers)
        {
            return numbers.Distinct().ToArray();
        }

        public static bool AllGreaterThan5(int[] numbers)
        {
            //return (from num in numbers select num).All(n => n > 5);
            return numbers.All(n => n > 5);
        }

        public static bool AnyGreaterThan5(int[] numbers)
        {
            //return (from num in numbers select num).Any(n => n > 5);
            return numbers.Any(n => n > 5);
        }

        public static int FindFirstOrDefault(int[] numbers)
        {
            //return (from num in numbers select num).FirstOrDefault(n  => n > 5);
            return numbers.FirstOrDefault(n => n > 5);
        }

    }
}
