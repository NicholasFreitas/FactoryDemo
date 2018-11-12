using System;

namespace FactoryDemo
{
    class ProductOne : IProduct
    {
        public ProductOne()
        {
            Console.WriteLine("Product One Implementation.");
        }
    }
}
