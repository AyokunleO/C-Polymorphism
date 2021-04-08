using System;
using System.Collections.Generic;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var savingsAccount = new SavingsAccount("David", "Busting", 6000M, 0.3M);
            var currentAccount = new CurrentAccount("Michael", "Smith", 4000M);

            Console.WriteLine($"Initial account balance");
            Console.WriteLine($"{savingsAccount} Balance: {savingsAccount.Balance:C}");
            Console.WriteLine($"{currentAccount} Balance: {currentAccount.Balance:C}");

            Console.WriteLine($"\nPolymorphic Account Balance");

            List<Account> accounts = new List<Account>(){savingsAccount, currentAccount};

            foreach (var account in accounts)
            {
                if(account is SavingsAccount)
                {
                    var newAccount = (SavingsAccount)account;
                    Console.Write($"{newAccount}: ");
                    // var inco = newAccount.CalculateInterest();
                    newAccount.Credit(newAccount.CalculateInterest());
                    Console.WriteLine($"Balance after Interest: {newAccount.Balance:C}");
                }else{
                    Console.WriteLine($"{account} Balance: {account.Balance:C}");
                }
            }
        }
    }
}
