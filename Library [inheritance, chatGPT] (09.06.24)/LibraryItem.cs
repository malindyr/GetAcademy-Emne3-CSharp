using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library__inheritance__chatGPT___09._06._24_
{
    internal class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; set; }

        public LibraryItem(string title, string author, string isbn, bool isborrowed)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = isborrowed;
        }

        public virtual void Return()
        {

        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"\r\n title:{Title} \r\n author: {Author} \r\n isbn {ISBN} \r\n is borrowed? {IsBorrowed}");
        }
    }
}
