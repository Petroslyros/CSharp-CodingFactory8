namespace EurosToDollars
{

    //Reads an integer that represents the euros
    //and converts from euros to dollars, 
    //based on a conversion rate 1 euro = 1.07 USD.
    internal class Program
    {
        static void Main(string[] args)
        {

            const decimal RATE = 1.07m;
            decimal totalCents;
            decimal dollars;
            decimal cents;

            Console.WriteLine("Please input the sum in Euros : ");

            if(!decimal.TryParse(Console.ReadLine(), out decimal inputEuros))
            {
                Console.WriteLine("Error in input");
                return;
            }

            totalCents = inputEuros * RATE;
            dollars = totalCents / 100;
            cents = totalCents % 100;


            Console.WriteLine($"\u20AC {inputEuros:N2} convert to \u0024 {totalCents:N0} {cents,5:N0} cents");


        }
    }
}
