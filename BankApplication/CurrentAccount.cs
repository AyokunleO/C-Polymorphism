namespace BankApplication
{
    public class CurrentAccount: Account
    {
        public CurrentAccount(string fName, string lName, decimal balance):base(fName,lName,balance)
        {
            
        }
        public override decimal Credit(decimal amount)
        {
            return Balance + amount;
        }
        public override decimal Debit(decimal amount)
        {
            return Balance - amount;
        }
    }
}