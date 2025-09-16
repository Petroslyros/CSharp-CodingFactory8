using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StrHelperMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        // === 1. Array Minimum ===
        static void ArrayMinimum()
        {
            int[] ages = { 15, 25, 12, 55 };
            int minPosition = 0;

            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < ages[minPosition])
                {
                    minPosition = i;
                }
            }

            Console.WriteLine($"Min Value: {ages[minPosition]}, Min Position: {minPosition + 1}");
        }

        // === 2. Count Positives Until Negative ===
        static void CountPositives()
        {
            int count = 0;

            Console.WriteLine("Please input an integer: ");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            while (num >= 0)
            {
                if (num > 0) count++;

                Console.WriteLine("Please input an integer: ");
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Wrong input");
                    return;
                }
            }

            Console.WriteLine($"The count of positives is {count}");
        }

        // === 3. Palindrome Check ===
        static void PalindromeCheck()
        {
            int[] ints = { 1, 2, 3, 2, 1 };
            bool isPalindrome = true;

            for (int i = 0, j = ints.Length - 1; i < j; i++, j--)
            {
                if (ints[i] != ints[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine($"Is Palindrome: {isPalindrome}");
        }

        // === 4. String Helper Methods ===
        static void StringHelpers()
        {
            string str1 = "Hello, World";
            string str2 = "Hello, C# !   ";

            Console.WriteLine(str1.ToUpper());   // "HELLO, WORLD"
            Console.WriteLine(str1.ToLower());   // "hello, world"
            Console.WriteLine(str2.Trim());      // "Hello, C# !"

            bool result = str1.ToUpper() == str2.ToUpper();
            Console.WriteLine($"Equal ignoring case: {result}");

            Console.WriteLine($"IndexOf 'World': {str1.IndexOf("World")}");
            Console.WriteLine($"LastIndexOf 'o': {str1.LastIndexOf("o")}");
            Console.WriteLine($"Substring: {str1.Substring(7, 5)}");

            Console.WriteLine(str1.Replace("World", "C#"));
            Console.WriteLine(Regex.Replace(str1, @"\s+", "_"));

            string[] words = str1.Split(',');
            Console.WriteLine(string.Join(" - ", words));

            bool contains = str1.Contains("World");
            bool startsWith = str1.StartsWith("Hello");
            Console.WriteLine($"Contains 'World': {contains}, StartsWith 'Hello': {startsWith}");

            Console.WriteLine($"Length: {str1.Length}");
            Console.WriteLine(string.Format("{0} and {1}", str1, 10));

            Console.WriteLine(str1.PadLeft(20).PadRight(25, '*'));

            string joined = string.Concat(str1, " ", str2);
            Console.WriteLine(joined);

            string reversed = new string(str1.Reverse().ToArray());
            Console.WriteLine($"Reversed: {reversed}");
        }
    }
}
