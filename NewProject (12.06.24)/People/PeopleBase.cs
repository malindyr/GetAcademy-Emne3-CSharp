using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject__12._06._24_.People
{
    internal class PeopleBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int FriendShipLevel { get; set; }
        public List<string> Phrases { get; set; }
        public string Mood {  get; set; }

    /*    public PeopleBase(string name, string desctiption, int friendshipLevel, List<string> phrases, string mood) {
        
            Name = name;
            Description = desctiption;
            FriendShipLevel = friendshipLevel;
            Phrases = phrases;
            Mood = mood;
        }*/
    }


}


