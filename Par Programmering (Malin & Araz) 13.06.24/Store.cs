using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_Programmering__Malin___Araz__13._06._24
{
    internal class Store
    {
        public List<InventoryItem> ItemsInStore { get; set; } = new List<InventoryItem>();
        public void AddItem(InventoryItem item)
        {
            ItemsInStore.Add(item);
        }

        public string FindItemInTheBack(/*string itemName*/) 
        {
            foreach (var item in ItemsInStore)
            {
                item.DisplayInfo();
            }

            var answer = Console.ReadLine();
            var FoundItem = ItemsInStore.FirstOrDefault(x => x.Name == answer);

            if (FoundItem != null)
            {
                return $"item found! {FoundItem.Name}";
            }
            else
            {
                return "item not found";
            }
        }

        public void ListItemsByPrice()
        {
            var ItemsByPrice = ItemsInStore.OrderBy(x => x.Price);
            foreach (var item in ItemsByPrice)
            {
                Console.WriteLine($"item name: {item.Name}, item price: {item.Price}");
            }
        }
    }
}
