using System;

namespace StrEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "AUEB";
            string s2 = "AUEB";

            Console.WriteLine($"{s1.Equals(s2)}");                  //ισοτητα περιοχμενου
            Console.WriteLine($"{s1 != s2}");
            Console.WriteLine($"{Object.ReferenceEquals(s1,s2)}");  //ισοτητα αναφορας

            int result = s1.CompareTo( s2 );        //λεξικογραφικη συγκριση
            int result2 = string.Compare( "HELLO", "hello", true); //λεξικογραφικη συγκριση -- Null safe
        }
    }
}
