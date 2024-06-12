using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System__12._06._24_
{

    //Multimedia will have additional information such as format (e.g., DVD, Blu-ray) and duration.
    //Book and Multimedia inherit from LibraryItem and add specific properties for books and multimedia items respectively.
    internal class MultiMedia : LibraryItem, IRentable
    {
        public string Format { get; set; }
        public int Duration { get; set; }
        public MultiMedia(string title, int quantity, double baseRentalPrice, string format, int duration) : base(title, quantity, baseRentalPrice)
        {
            Title = title;
            Quantity = quantity;
            BaseRentalPrice = baseRentalPrice;
            Format = format;
            Duration = duration;
        }

        public double CalculateRentalPrice()
        {
            //5% tax im afraid
            var Tax = BaseRentalPrice * 0.05;
            var PriceAfterTax = BaseRentalPrice + Tax;
            return PriceAfterTax;
        }
    }
}
