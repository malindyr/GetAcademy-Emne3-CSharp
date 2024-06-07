using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lagersystem__moodle__05._06._24_
{
    internal class  Clothes : IProduct
    {

        //Egenskap: Størrelse.
        public string Name { get; set; }
        public double Price { get; set; }

        public string Size { get; set; } 

        public Clothes(string name, double price, string size )
        {
            Name = name;
            Price = price;
            Size = size;
            Warehouse.AddProduct(this);
        }
        public void PrintInfo()
        {
            Console.WriteLine($"name: {Name}, price: {Price}, size: {Size}");
        }
    }
}
