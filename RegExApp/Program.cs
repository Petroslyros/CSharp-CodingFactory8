using System.Text.RegularExpressions;

namespace RegExApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "This is CF!";
            string s2 = "12-05-1980 15-09-1990";
            testGroups(s2);
            
            //bool isMatch = TestCF(s);
            //Console.WriteLine(isMatch);

            //TestMatch(s);
        }

        string s2 = @"CF";
        public static bool TestCF(string? s)
        {
            string? pattern = @"^$CF";

            bool isMatch = Regex.IsMatch(s!, pattern);
            return isMatch;
        }

        public static void TestMatch(string? s)
        {
            string? pattern = @"CF";
            Match match = Regex.Match(s!, pattern);

            if(match.Success)
            {
                Console.WriteLine($"Found match : {match.Value} at index {match.Index}");
            } 
            else
            {
                Console.WriteLine("No match found.");
            }
        }

        public static void TestMatches(string? s)
        {
            string? pattern = @"\d+"; //match sequences of digits

            MatchCollection matches = Regex.Matches(s!, pattern);
            foreach(Match match in matches)
            {
                Console.WriteLine($"Found match: {match.Value} at index {match.Index}");
            }
        }

        public static void testGroups(string? s)
        {
            if(s == null) return;
            string? pattern = @"(\d{4})-(\d{2})-(\d{2})";   //match date
            MatchCollection matches = Regex.Matches(s!, pattern);

            foreach(Match m in matches)
            {
                Console.WriteLine($"Full Match : {m.Value}");
                for(int i = 0; i < m.Groups.Count; i++)
                {
                    Console.WriteLine($"Group {i} : {m.Groups[i].Value}");
                }
            }
            
        }

        public static bool TestPassword(string? input)
        {
            return Regex.IsMatch(input!, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[@$!%*?&])^.{8,}$");
        }

    }
}
