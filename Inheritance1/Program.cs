using System;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product("sugar", 1000, 1),
                new Product("salt", 2000, 2),
                new FixedDiscountProduct("ice cream", 300, 2, 50),
                new FixedDiscountProduct("chocolate", 600, 1, 60),
                new DiscountedProduct("candy", 500, 0, 5.825m),
                new DiscountedProduct("bread", 900, 1, 2.5m)
            };

            Product maxCostProduct = products[0];
            bool equal = true;

            foreach (var item in products)
            {
                if (equal)
                {
                    equal = maxCostProduct.Equals(item);
                }               

                if(item.GetCost() > maxCostProduct.GetCost())
                {
                    maxCostProduct = item;
                }

                Console.WriteLine(item.Name + " - " + item.GetCost());
            }

            Console.WriteLine();
            Console.WriteLine("The most expensive purchase - " + maxCostProduct.Name);
            Console.WriteLine();
            Console.WriteLine("Are all purchases equal? - " + (equal ? "yes" : "no").ToString());
            Console.Read();
        }
    }
}
