using System;
namespace PackageApp
{
    public abstract class Package
    {
        public string SenderAdd { get; set; }
        public string RecipientAdd { get; set; }

        private decimal weight;
        private decimal cost;

        public Package(string senderAdd, string recipientAdd, decimal weight, decimal cost)
        {
            SenderAdd = senderAdd;
            RecipientAdd = recipientAdd;
            Weight = weight;
            Cost = cost;
        }
        public decimal Weight
        {
            get { return weight; }
            set {
                if(value>0){
                    weight = value;
                }
                }
        }

        public decimal Cost
        {
            get { return cost; }
            set {
                if(value>0){
                    cost = value;
                }
                }
        }

        public abstract decimal CalculateCost();

        public override string ToString()
        {
            return $"{SenderAdd} {RecipientAdd}{Weight}";
        }
    }
}