using System;
namespace PackageApp
{
    public class OvernightPackage: Package
    {
        private decimal overnightCost;
        public OvernightPackage(string senderAdd, string recipientAdd, decimal overnightCost): base(senderAdd, recipientAdd)
        {
            OvernightCost = overnightCost;
        }
        public decimal OvernightCost
        {
            get { return overnightCost; }
            set { 
                if(value>0)
                {
                    overnightCost = value;
                }
                }
        }
        public override decimal CalculateCost()
        {
            return OvernightCost;
        }

        
    }
}