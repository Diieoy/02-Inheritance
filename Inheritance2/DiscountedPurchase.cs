using System;

namespace Inheritance2
{
    class DiscountedPurchase : AbstractPurchase
    {
        public const int QuantityForDiscount = 5;
        private decimal discount;

        public DiscountedPurchase(Commodity commodity, int quantity, decimal discount) : base(commodity, quantity)
        {
            this.discount = discount;
        }

        public decimal Discount { get => discount; set => discount = value; }       

        public override decimal GetCost()
        {
            if (discount > 100)
            {
                throw new Exception("The discount can't be more than 100 %");
            }

            if (Quantity >= QuantityForDiscount)
            {
                return (decimal.Round(Commodity.Price * Quantity * (1 - discount / 100)));
            }
            else
            {
                return (Commodity.Price * Quantity);
            }
        }

        public override string ToString()
        {
            return (base.ToString() + QuantityForDiscount + ";" + discount + ";" + GetCost() + ";");
        }
    }
}
