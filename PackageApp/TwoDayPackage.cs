using System;
namespace PackageApp
{
    public class TwoDayPackage: Package
    {
        private decimal twoDayCost;
        public TwoDayPackage(string senderAdd, string recipientAdd, decimal twoDayCost): base(senderAdd, recipientAdd)
        {
            TwoDayCost = twoDayCost;
        }
        public decimal TwoDayCost
        {
            get { return twoDayCost; }
            set { 
                if(value>0)
                {
                    twoDayCost = value;
                }  
                }
        }
        public override decimal CalculateCost()
        {
            return TwoDayCost;
        }

    }
}