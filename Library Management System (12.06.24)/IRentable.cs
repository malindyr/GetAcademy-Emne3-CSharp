using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System__12._06._24_
{
    /*Interface: IRentable
    Contains a function to calculate the rental price, which might include discounts 
    (e.g., weekend special with a 30% discount) or additional charges (e.g., rental tax).*/
    /*IRentable is an interface with a method CalculateRentalPrice that is implemented in both derived classes to calculate the rental price, 
    taking into account potential discounts or taxes.*/
    public interface IRentable
    {
        public double CalculateRentalPrice();
    }
}
