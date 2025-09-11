using System.Text.RegularExpressions;

namespace StrHelperMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello, World";
            string str2 = "Hello, C# !   ";

            string upper = str1.ToUpper();  //"HELLO, WORLD!"
            string lower = str1.ToLower();  //hello, world!
            string trimmed = str2.Trim();  // Hello, C#

            bool result = str1.ToUpper() == str2.ToUpper(); // normalization for comparison

            int index = str1.IndexOf("World"); // 7
            int lastIndex = str1.LastIndexOf("o"); // 8
            string substring = str1.Substring(7, 5); // "World"


            string replaced = str1.Replace("World", "C#");
            string replaceRegex = Regex.Replace(str1, @"\s+", "_"); 

            string[] words = str1.Split(','); // ["Hello", "World!"]
            string[] tokens = Regex.Split(str1, @"\W+"); // ["Hello", World"]



            bool contains = str1.Contains("World"); //true
            bool startWith = str1.StartsWith("Hello"); //true
            
            int length = str1.Length; //13
            string formatted = string.Format("{0} and {1}", str1, 10); // "Greeting, Hello World"
            string joined = string.Join(" - ", words); //"Hello - World!"

            //Validation
            bool isNullOrEmpty = string.IsNullOrEmpty(str1); // false
            bool isNullOrWhiteSpace = string.IsNullOrEmpty("   ");


            string padded = str1.PadLeft(20).PadRight(25, '*');

            string joined1 = string.Concat(str1, " ", str2); //"Hello, World"
            string joined2 = str1 + " " + str2; //  "Hello, World!   Hello, C#!"

            string reversed = new string (str1.Reverse().ToArray());  // !dlroW ,olleH"

        }
    }
}
