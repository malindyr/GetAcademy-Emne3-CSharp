using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewProject__12._06._24_.Environments;
using NewProject__12._06._24_.Objects;
using NewProject__12._06._24_.People;

namespace NewProject__12._06._24_.Area
{
    internal class Forest : AreaBase
    {
        public Forest(Vibe vibe, List<PeopleBase> characters, List<Items> itemshere) : base(vibe, characters, itemshere)
        {
        }
    }
}
