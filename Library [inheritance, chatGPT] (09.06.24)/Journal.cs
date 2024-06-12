using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library__inheritance__chatGPT___09._06._24_
{
    /*    Journal (inherits from LibraryItem)
        DateTime PublicationDate
        Additional Methods:
        Override PrintDetails() to include the issue number and publication date.*/
    internal class Journal : LibraryItem
    {
        public int IssueNumber { get; set; }
        public string PublicationDate { get; set; }
        public Journal(string title, string author, string isbn, bool isborrowed, int issueNumber, string publicationDate) : base(title, author, isbn, isborrowed)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = isborrowed;
            IssueNumber = issueNumber;
            PublicationDate = publicationDate;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"issue number: {IssueNumber} \r\n publicationDate: {PublicationDate} \r\n");
        }
    }
}
