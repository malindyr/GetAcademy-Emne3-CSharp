using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagersystem__moodle__05._06._24_
{
    internal class Electronics : IProduct
    {

        //Egenskap: Garantitid (i måneder).
        public string Name { get; set; }
        public double Price { get; set; }
        public int Warranty {get; set;}

        public Electronics(string name, double price, int warranty)
        {
            Name = name;
            Price = price;
            Warranty = warranty;
            Warehouse.AddProduct(this);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"name: {Name}, price: {Price}, warranty: {Warranty}");
        }
    }
}
