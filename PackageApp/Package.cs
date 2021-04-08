using System;
namespace PackageApp
{
    public abstract class Package
    {
        public string SenderAdd { get; set; }
        public string RecipientAdd { get; set; }

        public Package(string senderAdd, string recipientAdd)
        {
            SenderAdd = senderAdd;
            RecipientAdd = recipientAdd;
        }

        public abstract decimal CalculateCost();

        public override string ToString()
        {
            return $"{SenderAdd} {RecipientAdd}";
        }
    }
}