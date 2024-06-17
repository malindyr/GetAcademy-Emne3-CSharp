using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_Programmering__Malin___Araz__13._06._24
{

    //30% salg
    internal class ClothingItem : InventoryItem, Isellable
    {

        public string Size { get; private set; }
        public string Color { get; private set; }
        public ClothingItem(string name, int amount, double price, string size, string color) : base(name, amount, price)
        {
            Name = name;
            Amount = amount;
            Price = price;
            Size = size;
            Color = color;
        }

        public void CalculatePrice()
        {
            Console.WriteLine($" {this.Name} before discount {Price}");

            var Discount = Price * 0.3;
            Price -= Discount;

            Console.WriteLine($"price after discount {Price}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($" size: {Size}, color: {Color}");
        }

    }
}
