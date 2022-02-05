using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    
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
            //sBasket.Remove(10);
            sBasket.Remove(3);

            sBasket.ListTheProducts();
        }
    }
}
