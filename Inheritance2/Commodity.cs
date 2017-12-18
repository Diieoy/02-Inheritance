namespace Inheritance2
{
    class Commodity
    {
        private string name;
        private decimal price;

        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }

        public Commodity() { }
        public Commodity(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return (name + ";" + price);
        }
    }
}
