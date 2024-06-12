using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System__12._06._24_
{
    //Book will have additional information such as author and genre.
    //Book and Multimedia inherit from LibraryItem and add specific properties for books and multimedia items respectively.
    internal class Book : LibraryItem, IRentable
    {

        public string Author { get; private set; }
        public string Genre { get; private set; }
        public Book(string title, int quantity, double baseRentalPrice, string author, string genre) : base(title, quantity, baseRentalPrice)
        {
            Title = title;
            Quantity = quantity;
            BaseRentalPrice = baseRentalPrice;
            Author = author;
            Genre = genre;
        }

        public double CalculateRentalPrice()
        {

            //30% sale on books
            var Discount = BaseRentalPrice * 0.3;
            var DiscountPrice = BaseRentalPrice - Discount;

            return DiscountPrice;

        }
    }
}
