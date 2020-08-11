using System;

namespace NedarvningS3
{
    public class Invoice: Payable
    {
        protected string partNumber;
        protected string partDescription;
        protected int quantity;
        protected double pricePerItem;

        public Invoice(string partNumber, string partDescription, int quantity, double pricePerItem)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            PricePerItem = pricePerItem;
        }

        public virtual string PartNumber
        {
            get
            {
                return partNumber;
            }

            set
            {
                partNumber = value;
            }
        }

        public virtual string PartDescription
        {
            get
            {
                return partDescription;
            }

            set
            {
                partDescription = value;
            }
        }

        public virtual int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public virtual double PricePerItem
        {
            get
            {
                return pricePerItem;
            }

            set
            {
                pricePerItem = value;
            }
        }

        public virtual double GetPaymentAmount()
        {
            return quantity * pricePerItem;
        }
    }
}