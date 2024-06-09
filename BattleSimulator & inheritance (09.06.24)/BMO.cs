using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulator___inheritance__09._06._24_
{
    internal class BMO : GameCharacterBase
    {
        public BMO(int strength, int health, int stamina) : base(strength, health, stamina)
        {
            Strength = strength;
            Health = health;
            Stamina = stamina;
        }

        public override void Fight(GameCharacterBase opponent)
        {
            Print("Choose the strength you would like to strike with by pressing the corresponding number \r\n 1. 10 \r\n 2. 20 \r\n 3. 30");
            int[] ValidStrengths = {1,2,3};
            var GivenAnswer = Console.ReadLine();

            if (int.TryParse(GivenAnswer, out int StrengthToUse) && ValidStrengths.Contains(StrengthToUse)) 
            {
                Strength = StrengthToUse * 10;
                base.Fight(opponent);
            } else
            {
                Print("You spent your turn clicking the wrong buttons");
            }
        }
    }
}
