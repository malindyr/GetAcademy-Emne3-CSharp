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
    internal class AreaBase
    {
        public Vibe VibeHere {  get; set; }
        public List <PeopleBase> CharactersHere { get; set; }
        public List <Items> ItemsHere { get; set; }

        public AreaBase(Vibe vibe, List<PeopleBase> characters, List<Items> itemshere)
        {
            VibeHere = vibe;
            CharactersHere = characters;
            ItemsHere = itemshere;
        }
    }
}
