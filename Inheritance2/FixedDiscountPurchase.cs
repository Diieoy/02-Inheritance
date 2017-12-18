using System;

namespace Inheritance2
{
    class FixedDiscountPurchase : AbstractPurchase
    {
        private decimal discountInRubles;

        public FixedDiscountPurchase(Commodity commodity, int quantity, decimal discountInRubles) : base(commodity, quantity)
        {
            this.discountInRubles = discountInRubles;
        }

        public decimal DiscountInRubles { get => discountInRubles; set => discountInRubles = value; }

        public override decimal GetCost()
        {
            if (discountInRubles > Commodity.Price)
            {
                throw new Exception("The discount can't be more than price");
            }

            if (discountInRubles > 0)
            {
                return (decimal.Round((Commodity.Price - discountInRubles) * Quantity));
            }
            else
            {
                return (Commodity.Price * Quantity);
            }            
        }

        public override string ToString()
        {
            return (base.ToString() + discountInRubles + ";" + GetCost() + ";");
        }
    }
}
