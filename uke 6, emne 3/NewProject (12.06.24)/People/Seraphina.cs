using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject__12._06._24_.People
{
    internal class Seraphina : PeopleBase
    {
        public Seraphina()
        {
            Name = "Seraphina";
            Description = "Seraphina is a bit confusing. She never looks me in the eye when she talks. It makes me wonder and... I'm not sure.. There's talk about her wandering the forest at night. People speculate, but who knows? Maybe she just likes the quiet. Or maybe there's more to it. Hard to say..";
            FriendShipLevel = 0;
            Phrases = new List<string> {"'There's strange things happening around here. You.. shouldn't be here'", 
                                        "*Serena meets your eye and immediately looks away. She looks anxious*",
                                        "'You shouldn't stay here...'"};
        }

        public string Greet()
        {
            return "Seraphina glances your way briefly, then looks away. 'Hello,' she murmurs.";
        }

        public string Interact(int playerChoice)
        {
            string response;
            switch (playerChoice)
            {
                case 1:
                    response = "Seraphina frowns and shakes her head. 'That's not quite right...'";
                    break;
                case 2:
                    response = "Seraphina gives you a puzzled look. 'I don't think that's what I meant...'";
                    break;
                case 3:
                    response = "Seraphina answers but does not meet your gaze. 'Yes...  To find the village, follow the river upstream.. Don't tell anyone you saw me.'";
                    break;
                default:
                    response = "Seraphina doesn't understand your choice.";
                    break;
            }
            return response;
        }
    }
}
