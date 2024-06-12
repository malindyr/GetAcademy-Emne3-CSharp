using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library__inheritance__chatGPT___09._06._24_
{
    /*  DVD (inherits from LibraryItem)

        Additional Properties:
        int Duration (in minutes)
        Additional Methods:
        Override PrintDetails() to include the duration.*/
    internal class DVD : LibraryItem
    {
        public int Duration { get; set; }
        public DVD(string title, string author, string isbn, bool isborrowed, int duration) : base(title, author, isbn, isborrowed)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = isborrowed;
            Duration = duration;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"duration in minutes: {Duration} \r\n");
        }
    }
}
