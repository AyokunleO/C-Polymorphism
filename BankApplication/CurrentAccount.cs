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