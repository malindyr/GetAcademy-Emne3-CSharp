using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dangerbud__parprogrammering__19._06._24
{
    //  Husflue (kan fly,plage:  kan spre sykdommer)
    internal class Fly : Bug
    {
        public Fly() : base("fly", true, 6, "flying", "can spread sickness"){}
    }
}
