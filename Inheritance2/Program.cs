using System;

namespace Inheritance2
{
    class Program
    {
        private static void showPurchases(AbstractPurchase[] purchases)
        {
            foreach (var item in purchases)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            AbstractPurchase[] purchases =
            {
                new FixedDiscountPurchase(new Commodity("salt", 1500), 1, 50),
                new FixedDiscountPurchase(new Commodity("sugar", 1000), 2, 20),
                new DiscountedPurchase(new Commodity("bread", 900), 2, 0),
                new DiscountedPurchase(new Commodity("bubblegum", 500), 10, 3.452m),
                new TransportPurchase(new Commodity("apple", 600), 50, 1000),
                new TransportPurchase(new Commodity("pinapple", 2000), 10, 5000)
            };

            showPurchases(purchases);

            Array.Sort(purchases);
            showPurchases(purchases);

            Console.Read();
        } 
    }
}
