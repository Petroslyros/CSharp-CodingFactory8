using AccountApp.Exceptions;
using AccountApp.Model;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account()
            {
                Id = 1,
                Iban = "Gr123",
                Firstname = "Petros",
                Lastname = "Lyros",
                Balance = 1000,
                Ssn = "A12345"
            };

            try
            {
                account.Deposit(100);
                account.Withdraw(20, "A12345");
                account.Deposit(-10);

            } 
            catch (Exception ex)
            {
                if(ex is NegativeAmountException || ex is InsufficientAmountException || ex is InvalidSsnException)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            Console.WriteLine($"Account : {account}");
        }
    }
}
