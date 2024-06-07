using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagersystem__moodle__05._06._24_
{
    internal class Groceries : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int ExpirationDate {  get; set; }

        public Groceries(string name, double price, int expirationDate)
        {
            Name = name; 
            Price = price;
            ExpirationDate = expirationDate;
            Warehouse.AddProduct(this);

        }

        public void PrintInfo()
        {
            Console.WriteLine($"name: {Name}, price: {Price}, exp date: {ExpirationDate}");
        }
    }
}
