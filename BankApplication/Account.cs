using System;
namespace BankApplication
{
    public abstract class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private decimal balance;

        public Account(string fName, string lName, decimal balance)
        {
            FirstName = fName;
            LastName = lName;
            Balance = balance;
        }
        public decimal Balance
        {
            get { return balance; }
            set {
                if(value >=0)
                {
                    balance = value;
                }else{
                    throw new ArgumentOutOfRangeException();
                }
                 }
        }
        public abstract decimal Credit(decimal amount);
        public abstract string Debit(decimal amount);

        
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
        
    }
}