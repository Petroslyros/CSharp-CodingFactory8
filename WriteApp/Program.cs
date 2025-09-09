using System.Globalization;

namespace WriteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int result = 0;

            //Entoles
            result = num1 + num2;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("el-GR");

            //print
            Console.WriteLine("The sum of {0,6:C2} and {1,6:N2} is {2,10:N2",num1,num2,result);
            Console.WriteLine($"The sum of {num1,6:N2} + {num2,6:N2} is : {result,10:N2}");
        }
    }
}
