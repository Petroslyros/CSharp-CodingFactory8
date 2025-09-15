using System.Text;

namespace MethodsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DateTime dateTime = GetDateTime(day: 15, month: 8);
            DateTime dateTime2 = GetDateTime(2026, 12, 25, 10, 30, 0);
            Console.WriteLine($"{dateTime:F}");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial (n - 1);
        }

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static DateTime GetDateTime(int year = 2025, int month = 1, int day = 1,
                                            int hour = 0, int minute = 0, int second = 0,int milli = 0)
        {
            return new DateTime(year, month, day, hour, minute, second, milli);    
        }

        public static void PrintMessage(string message = "Hello, World!")
        {
            Console.WriteLine(message);
        }

        public static void PrintMessage(string prefix = "Message: ", string message = "Hello, World")
        {
            Console.WriteLine($"{prefix} {message}");
        }

        public static void PrintMessage(int inputNum)
        {
            Console.WriteLine($"{inputNum}");
        }

        public static bool isEven(int number)
        {
            return number % 2 == 0; 
        }

        public static bool isOdd(int number)
        {
            return !isEven(number);
        }

        public static int GetMax(int a, int b) => a > b ? a : b;
        //return Math.Max(a,b)

        public static double CelciusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static string StrRepeat(string s, int count)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i <= count; i++)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }

        public static bool isPalindromeIgnoreCase(string s)
        {
               for (int i = 0, j = s.Length; i< j; i++, j--)
            {
                if (char.ToUpper(s[i]) != char.ToUpper(s[j])) {
                    return false;
                }
            }
               return true; 
        }

        public static string RandomPinFourDigits()
        {
            Random random = new Random();
            int pin = random.Next(1000, 10000);
            return pin.ToString();
        }

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            int temp = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length -1; j > i; j--)
                {
                    if (arr[j] < arr[j-1])
                    {
                        (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
                    }
                }
            }
        }

        public static bool IsPrime(int number)
        {
            if(number<=10 ) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            
            for(int i = 3; i <= Math.Sqrt(number); i+=2 )
            {
                if(number % i == 0) return false;
            }
            return true;
        }

        public static int Fibonacci(int n)
        {
            int a = 0, b = 1, c = 0;

            if (n == 0) return 0;
            if( n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
                
        }
    }
}
