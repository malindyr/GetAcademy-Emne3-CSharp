using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._06._24
{
    //Boat: (has wheels: 0, can be driven, maximum speed: 80 km/h, fuel type: diesel, feature: can travel on water)
    internal class Boat : Veichle
    {
        public Boat() : base(0, true, 80){}

    }
}
