using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library__inheritance__chatGPT___09._06._24_
{

    internal class Book : LibraryItem
    {
        public int NumberOfPages { get; set; }
        public int IssueNumber { get; set; }
        public string PublicationDate { get; set; }
        public Book(string title, string author, string isbn, bool isborrowed, int numberOfPages, int issuenumber,  string publicationDate) : base(title, author, isbn, isborrowed)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = isborrowed;
            NumberOfPages = numberOfPages;
            IssueNumber = issuenumber;
            PublicationDate = publicationDate;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"issue number: {IssueNumber} \r\n publicationDate: {PublicationDate} \r\n number of pages: {NumberOfPages} \r\n");
        }
    }
}
