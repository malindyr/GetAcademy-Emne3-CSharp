using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_Programmering__Malin___Araz__13._06._24
{
    internal class Customer
    {
        public double Money { get; set; }
        public List<InventoryItem> ItemsBought { get; set; }

        public Customer(double money)
        {
            Money = money;
            ItemsBought = new List<InventoryItem>();
        }


        public void BuyItem(InventoryItem itemToBuy)
        {
            ItemsBought.Add(itemToBuy);

            Console.WriteLine($"You have {Money} simeleons. \r\n You just bought: {itemToBuy.Name} \r\n You paid {itemToBuy.Price}");
            Money -= itemToBuy.Price;
            Console.WriteLine($"you how have {Money} simeleons in your wallet");

        }
    }
}
