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
                if(value > 0){
                    interestRate = value;
                }
                 }
        }
        
        public decimal CalculateInterest()
        {
            decimal Interest = Balance * InterestRate;
            return Interest;
        }

        public override decimal Credit(decimal interest)
        {
            return Balance = Balance + CalculateInterest();
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