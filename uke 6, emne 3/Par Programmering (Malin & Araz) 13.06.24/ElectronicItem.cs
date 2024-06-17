using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_Programmering__Malin___Araz__13._06._24
{
    //skatt
    internal class ElectronicItem : InventoryItem, Isellable
    {
        public string Insurance { get; private set; }
        public string Voltage { get; private set; }
        public ElectronicItem(string name, int amount, double price, string insurance, string voltage) : base(name, amount, price)
        {
            Name = name; 
            Amount = amount;
            Price = price;
            Insurance = insurance;
            Voltage = voltage;
        }

        public void CalculatePrice()
        {
            //tax = 10%
            Console.WriteLine($" {this.Name} before discount {Price}");

            var Tax = Price * 0.1;
            Price += Tax;

            Console.WriteLine($"price after tax {Price}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"\r\n insurance: {Insurance}, voltage: {Voltage}");
        }
    }
}
