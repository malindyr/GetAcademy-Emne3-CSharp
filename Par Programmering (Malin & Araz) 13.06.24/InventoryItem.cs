using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_Programmering__Malin___Araz__13._06._24
{ 
    internal class InventoryItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public InventoryItem(string name, int amount, double price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"\r\n name: {Name}, amount: {Amount}, price: {Price}");
        }

    }
}
