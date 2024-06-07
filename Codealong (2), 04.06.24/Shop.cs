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
            Console.WriteLine("Enter the ID of the product to add to the cart:");
            var input = Console.ReadLine();
            var isValid = int.TryParse(input, out int id);

            if (isValid)
            {
                var product = Products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    Cart.Add(product);
                    Console.WriteLine($"Added {product.Name} to the cart.");
                }
                else
                {
                    Console.WriteLine("Product with the specified ID not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid product ID.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            bool continueShopping = true;

            while (continueShopping)
            {
                shop.AddToCart();
                Console.WriteLine("Do you want to add another product to the cart? (yes/no)");
                string response = Console.ReadLine().ToLower();
                continueShopping = response == "yes";
            }

            Console.WriteLine("Products in your cart:");
            foreach (var product in shop.Cart)
            {
                Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}, Id: {product.Id}");
            }
        }
    }
}
   