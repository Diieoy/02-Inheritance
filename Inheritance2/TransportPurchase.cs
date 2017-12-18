namespace Inheritance2
{
    class TransportPurchase : AbstractPurchase
    {
        private decimal transportCosts;

        public TransportPurchase(Commodity commodity, int quantity, decimal transportCosts) : base(commodity, quantity)
        {
            this.transportCosts = transportCosts;
        }

        public decimal TransportCosts { get => transportCosts; set => transportCosts = value; }

        public override decimal GetCost()
        {
            return (Commodity.Price * Quantity + transportCosts);
        }

        public override string ToString()
        {
            return (base.ToString() + transportCosts + ";" + GetCost() + ";");
        }
    }
}
