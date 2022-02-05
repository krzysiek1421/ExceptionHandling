using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; }
        public decimal Price { get; }

        public override string ToString()
        {
            return $"#############\n" +
                   $"Product name: {Name}\n" +
                   $"Product price: {Price}\n" +
                   $"#############\n";
        }
    }
}
