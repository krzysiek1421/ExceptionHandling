using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class BasketOverloadException : Exception
    {
        public int BasketSize { get; }
        public BasketOverloadException(int size):base(message:$"Basket overloaded. Current size: {size}")
        {
            BasketSize = size;
        }
    }

    class BasketBadIndexException : Exception
    {
        public BasketBadIndexException() : base(message: $"Index doesn't exist") 
        {
            //EMPTY BODY
        }
    }
    class ShoppingBasket
    {
        public int Count = 0;
        public const int BasketMaxSize = 6;
        private readonly Dictionary<int,Product> _shoppingBasket = new Dictionary<int,Product>();
        public int GetSize => Count; 
        public void Add(Product product)
        {
            if (Count < BasketMaxSize)
            {
                Count++;
                _shoppingBasket.Add(Count, product);
            }
            else throw new BasketOverloadException(Count);
            
        }

        public void ListTheProducts()
        {
            foreach (var product in _shoppingBasket)
            {
                Console.WriteLine(product.ToString());
            }
        }
        public void Remove(int productIndex)
        { 
            
            if (_shoppingBasket.ContainsKey(productIndex))
            {
                _shoppingBasket.Remove(productIndex);
                Count--;
            }
            else throw new BasketBadIndexException();
        }
    }

    class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"#############\n"+
                   $"Product name: {Name}\n" +
                   $"Product price: {Price}\n" +
                   $"#############\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sBasket = new ShoppingBasket();
            sBasket.Add(new Product("ananas", 15));
            sBasket.Add(new Product("cola", 115));
            sBasket.Add(new Product("sugar", 5));
            sBasket.Add(new Product("honey", 10));
            sBasket.Add(new Product("cat", 8));
            sBasket.Add(new Product("mcroyal", 1));
            //UNCOMMENT BELOW TO THROW AN EXCEPTION
            //sBasket.Add(new Product("pravda", 19));
            sBasket.Remove(10);

            sBasket.ListTheProducts();
        }
    }
}
