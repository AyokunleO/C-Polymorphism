using System;
namespace BankApplication
{
    public class SavingsAccount: Account
    {
        private decimal interestRate;

        public SavingsAccount(string fName, string lName, decimal balance, decimal interestRate):base(fName,lName,balance)
        {
            InterestRate = interestRate;
        }
        public decimal InterestRate
        {
            get { return interestRate; }
            set { 
                if(value > 0 && value < 1){
                    interestRate = value;
                }
                 }
        }
        
        public decimal CalculateInterest()
        {
            decimal Interest = Balance * InterestRate;
            return Interest;
        }

        public override decimal Credit(decimal amount)
        {
            return Balance = Balance + amount;
        }
        public override string Debit(decimal amount)
        {
            if(amount>Balance){
            return $"{Balance - amount}";
            }else{
                return $"Insufficient Balance";
            }
        }
    }
}