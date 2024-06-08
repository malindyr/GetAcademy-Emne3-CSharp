using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battle_simulator__06._08._24_
{
    interface ICharacter
    {

        int Stamina { get; set;  }
        int Health { get; set; }
        int Strength { get; set; }
        int _initialstamina { get; set; }

        public void Fight(ICharacter opponent);
        public void Recharge();
        public bool isAlive();

        public static void Print(string textLine)
        {
            Console.WriteLine(textLine);
        }
    }
}
