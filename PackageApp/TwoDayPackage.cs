using System;
namespace PackageApp
{
    public class TwoDayPackage: Package
    {
        public TwoDayPackage(string senderAdd, string recipientAdd, decimal weight, decimal cost): base(senderAdd, recipientAdd,weight,cost)
        {
        }

        public override decimal CalculateCost()
        {
            return (Weight * Cost);
        }

    }
}