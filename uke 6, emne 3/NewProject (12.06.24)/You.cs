using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewProject__12._06._24_.Area;
using NewProject__12._06._24_.Objects;
using NewProject__12._06._24_.People;

namespace NewProject__12._06._24_
{
    internal class You
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public List<Items> Inventory { get; set; }
        public List<PeopleBase> KnownCharacters { get; set; }
        public AreaBase CurrentArea { get; set; }

        public int Health { get; set; }
        public int Energy { get; set; }
        public int Strength {  get; set; }


        private int _InitialEnergy { get; set; }
        private int _InitialHealth {  get; set; }

        public void AddKnownCharacter(PeopleBase characterToAdd) 
        {
            KnownCharacters.Add(characterToAdd);
            Console.WriteLine($"{characterToAdd.Name} was added to your list of known characters");
        }
    }
}
