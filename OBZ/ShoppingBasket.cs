using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class ShoppingBasket
    {
        public int Count = 0;
        public const int BasketMaxSize = 6;
        private readonly Dictionary<int, Product> _shoppingBasket = new Dictionary<int, Product>();
        public void Add(Product product)
        {
            if (Count < BasketMaxSize)
            {
                Count++;
                _shoppingBasket.Add(Count, product);
            }
            else throw new BasketOverloadException(Count, $"Basket overloaded. Current size: {Count}");

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
}
