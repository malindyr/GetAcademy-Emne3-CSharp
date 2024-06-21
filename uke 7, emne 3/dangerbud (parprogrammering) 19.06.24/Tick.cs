using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dangerbud__parprogrammering__19._06._24
{
    // Flått (plage: kan gi alvorlig sykdom)
    internal class Tick : Bug
    {
        public Tick() : base(true, 8, "walk", "can make you seriously ill")
        {
            Name = this.GetType().Name;
        }
    }
}
