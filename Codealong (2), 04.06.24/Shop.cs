using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong__2___04._06._24
{
    internal class Shop
    {
        public List<Product> Products { get; private set; }
        public List<Product> Cart { get; private set; }

        public Shop()
        {
            Products = new List<Product>()
            {
                new Product("milk", 20),
                new Product("sugar", 15),
                new Product("egg", 40)
            };
            Cart = new List<Product>();
        }

        public void AddToCart()
        {
            var answer = int.TryParse(Console.ReadLine(), out int number);

            var cart = Products.Where(Products[answer]).ToList();            

        }
    }
}
