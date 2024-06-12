using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Library_Management_System__12._06._24_
{

    /* Base Class: LibraryItem
    Contains information about the item's title, quantity, and base rental price.*/

    //LibraryItem is the base class with properties for the title, quantity, and base rental price of the item.
    internal class LibraryItem
    {
        public string Title { get; set; }
        public int Quantity { get; set; }
        public double BaseRentalPrice { get; set; }

        public LibraryItem(string title, int quantity, double baseRentalPrice) 
        {
            Title = title;
            Quantity = quantity;
            BaseRentalPrice = baseRentalPrice;
        }
    }
}
