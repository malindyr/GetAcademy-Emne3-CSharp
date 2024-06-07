using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong__2___04._06._24
{
    internal class Product
    {
        public static int Counter = 0;
        public string Name { get; private set; }
        public int Price { get; private set; }
        public int Id { get; private set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
            Id = Counter++;
        }
    }
}
