using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._06._24
{
    //Bicycle: (has wheels: 2, can be driven, maximum speed: 25 km/h, fuel type: human power, feature: eco-friendly)
    internal class Bicycle : Veichle
    {
        public string FuelType { get; set; }
        public string Feature { get; set; }
        public Bicycle() : base(2, true, 25){}
    }
}
