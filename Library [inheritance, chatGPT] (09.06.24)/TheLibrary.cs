using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library__inheritance__chatGPT___09._06._24_
{
    /*
    Create a Library class that holds a collection of LibraryItem objects.

    Borrow and return items.
    Find and remove items by ISBN.
    Print details of each item.*/
    internal class TheLibrary
    {
        private List<LibraryItem> AllLibraryItems { get; } = new List<LibraryItem> ();
        private List<LibraryItem> AvailableItems { get; set; } = new List<LibraryItem>(); 
        private List<LibraryItem> BorrowedItems { get; } = new List<LibraryItem> ();

        public void AddItem(LibraryItem item)
        {
            AllLibraryItems.Add(item);
        }

        public void ItemsAvailable()
        {
            AvailableItems = new List<LibraryItem>(AllLibraryItems.Where(x => !x.IsBorrowed));

            //foreach (var item in AvailableItems) {Console.WriteLine($"\r\nitem title: {item.Title}\r\n");}
        }

        public void RemoveItem(string titleToDelete)
        {
            /*Console.WriteLine("Write the title of the book you would like to remove from the Library");
            var TitleToDelete = Console.ReadLine();*/

            var itemToDelete = AllLibraryItems.FirstOrDefault(x => x.Title == titleToDelete);
            if (itemToDelete != null)
            {
                AllLibraryItems.Remove(itemToDelete);
            } else
            {
                Console.WriteLine("item not found");
            }
            
            
        }

        public virtual void Borrow(LibraryItem item)
        {
            if (!item.IsBorrowed) 
            {
                item.IsBorrowed = true;

                BorrowedItems.Add(item);
                AvailableItems.Remove(item);
            } 
            else
            {
                Console.WriteLine("Canæt borrow unavailable item");
            }
            
        }

        public void FindItem(string isbn) 
        {
            var FoundItem = AllLibraryItems.FirstOrDefault(x => x.ISBN == isbn);

            if (FoundItem != null) 
            {
                Console.WriteLine($"item name: {FoundItem.Title}. ISBN: {FoundItem.ISBN}");
            } else
            {
                Console.WriteLine("ISBN not found");
            }
            
        }

        public void ListAllItems()
        {
            foreach (LibraryItem item in AllLibraryItems) 
            {
                Console.WriteLine($"title: {item.Title} \r\n");
            }
        }
    }
}
