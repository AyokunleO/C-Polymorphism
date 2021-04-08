using System;
namespace PackageApp
{
    public class OvernightPackage: Package
    {
        private decimal expressFee;
        public OvernightPackage(string senderAdd, string recipientAdd, decimal weight, decimal cost, decimal express): base(senderAdd, recipientAdd,weight,cost)
        {
            ExpressFee = expressFee;
        }
        public decimal ExpressFee
        {
            get { return expressFee; }
            set { 
                if(value>0)
                {
                    expressFee = value;
                }
                }
        }
        public override decimal CalculateCost()
        {
            return (Weight * Cost) + ExpressFee;
        }

        
    }
}