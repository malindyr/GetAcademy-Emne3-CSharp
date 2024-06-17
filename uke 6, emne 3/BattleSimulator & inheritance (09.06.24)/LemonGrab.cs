using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulator___inheritance__09._06._24_
{
    internal class LemonGrab : GameCharacterBase
    {
        public LemonGrab(int strength, int health, int stamina) : base(strength, health, stamina)
        {
            Strength = strength;
            Health = health;
            Stamina = stamina;
        }

        public override void Fight(GameCharacterBase opponent)
        {
            RandomizeStrength();
            base.Fight(opponent);
        }

        public void RandomizeStrength()
        {
            Random rand = new Random();
            Strength = rand.Next(0,30);
        }
    }
}
