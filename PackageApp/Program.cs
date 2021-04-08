using System;
using System.Collections.Generic;
namespace PackageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var overnightPackage = new OvernightPackage("Ota", "Lagos", 5000M);
            var twoDayPackage = new TwoDayPackage("Lagos", "England", 20000M);

            List<Package> packages = new List<Package>(){overnightPackage, twoDayPackage};
            var totalCost= 0M;
            foreach (var package in packages)
            {
                if(package is OvernightPackage)
                {
                    var newPackage1 = (OvernightPackage)package;
                    Console.WriteLine($"Sender Address: {newPackage1.SenderAdd}\nRecipient Address: {newPackage1.RecipientAdd}\nShipping Cost: {newPackage1.CalculateCost():C}\n");
                    totalCost += newPackage1.CalculateCost();
                }else{ 
                    Console.WriteLine($"Sender Address: {package.SenderAdd}\nRecipient Address: {package.RecipientAdd}\nShipping Cost: {package.CalculateCost():C}\n");  
                    totalCost += package.CalculateCost();
                }
            }
            Console.WriteLine($"Total Cost of shipping the packages is: {totalCost:C}");
        }
    }
}
