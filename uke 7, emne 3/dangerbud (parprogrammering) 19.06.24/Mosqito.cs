using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dangerbud__parprogrammering__19._06._24
{
    //Lag klasser for mygg med dens unike egenskaper (kan fly, suger blod, gir følgende plage: kløe)
    internal class Mosqito : Bug
    {
        public Mosqito() : base(true, 6, "flying", "itching") { }
    }
}
