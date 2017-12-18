namespace Inheritance1
{
    class FixedDiscountProduct : Product
    {
        private decimal discountInRubles;

        public decimal DiscountInRubles { get => discountInRubles; set => discountInRubles = value; }

        public FixedDiscountProduct(string name, decimal price, int quantity, decimal discountInRubles) : base(name, price, quantity)
        {
            this.discountInRubles = discountInRubles;
        }       

        public override decimal GetCost()
        {          
            if(discountInRubles > Price)
            {
                throw new System.Exception("The discount can't be more than price");
            }

            if (discountInRubles > 0)
            {
                return (decimal.Round((Price - discountInRubles) * Quantity));
            }
            else
            {
                return base.GetCost();
            }           
        }

        public override string ToString()
        {
            return (base.ToString() + discountInRubles + ";" + GetCost() + ";");
        }
    }
}
