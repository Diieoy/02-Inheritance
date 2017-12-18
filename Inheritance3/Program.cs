using System;

namespace Inheritance3
{
    class Program
    {
        private static void showOperations(AbstractOperation[] operations)
        {
            foreach (var item in operations)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            AbstractOperation[] operations =
            {
                new AdditionOperation(2, 2),
                new AdditionOperation(5, 10),
                new SubtractionOperation(4, 10),
                new SubtractionOperation(100, 50),
                new MultiplicationOperation(4, 10),
                new MultiplicationOperation(2, 20),
                new DivisionOperation(10, 5),
                new DivisionOperation(10, 2),
                new ExponentiationOperation(2, 6),
                new ExponentiationOperation(8, 0)
            };

            showOperations(operations);

            Array.Sort(operations);
            showOperations(operations);

            Console.Read();
        }
    }
}
