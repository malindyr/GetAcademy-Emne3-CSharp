using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagersystem__moodle__05._06._24_
{
    internal class Warehouse
    {

        /*Lag en klasse Lager som inneholder en liste av IProdukt. Implementer følgende funksjonalitet:

        Metode for å legge til et produkt i lageret.
        Metode for å fjerne et produkt fra lageret.
        Metode for å liste opp alle produkter i lageret.*/

        public static List<IProduct> Products { get; set; }

        public Warehouse()
        {
            Products = new List<IProduct>();
        }

        public static void AddProduct(IProduct product) { 
        
            Products.Add(product);
        }

        public void RemoveProduct(IProduct product) { 
            
            Products.Remove(product); 
        }

        public IProduct FindProduct(string name)
        {          
                return Products.FirstOrDefault(n => n.Name == name);
        }
        public void DisplayProducts()
        {
            foreach (IProduct product in Products)
            {
                product.PrintInfo();
            }
        }

    }
}
