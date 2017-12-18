using System;

namespace Inheritance2
{
    abstract class AbstractPurchase : IComparable<AbstractPurchase>
    {
        private Commodity commodity;
        private int quantity;

        public int Quantity { get => quantity; set => quantity = value; }
        internal Commodity Commodity { get => commodity; set => commodity = value; }

        public AbstractPurchase() { }
        public AbstractPurchase(Commodity commodity, int quantity)
        {
            this.commodity = commodity;
            this.quantity = quantity;
        }

        abstract public decimal GetCost();

        public override string ToString()
        {
            return (commodity + ";" + quantity + ";");
        }

        public int CompareTo(AbstractPurchase o)
        {           
            if(GetCost() > o.GetCost())
            {
                return -1;
            }

            if(GetCost() < o.GetCost())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
