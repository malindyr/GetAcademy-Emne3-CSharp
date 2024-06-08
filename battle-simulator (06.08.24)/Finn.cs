using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battle_simulator__06._08._24_


{
    class Finn : ICharacter
    {
        public int Stamina { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int _initialstamina { get; set; }

        public Finn(int stamina, int health, int strength)
        {
            Stamina = stamina;
            Health = health;
            Strength = strength;
            Stamina = stamina;
            _initialstamina = Stamina;
        }


        public static void Print(string textLine)
        {
            Console.WriteLine(textLine);
        }

        /* * Helten blir spilt av deg med bruk av Console.ReadLine, mens motparten blir spilt av dataen.*/
        public void Fight(ICharacter opponent)
        {
            int[] validStrengthsArray = {1, 2, 3};
            Print("choose strength to hit with; \r\n 1, 2 or 3. Press corresponding number"); //print func
            var input = Console.ReadLine(); //parse -> console.readline()

            if (int.TryParse(input, out int strengthToUse) && validStrengthsArray.Contains(strengthToUse))
            {
                if (Stamina >= 10)
                {
                    opponent.Health -= strengthToUse * 10;
                    Print($"you hit {opponent.GetType().Name} with {strengthToUse * 10} strength! {opponent.GetType().Name}'s health is now at {opponent.Health}");
                    Stamina -= strengthToUse * 5;
                    Print($"after the hit, your stamina is: {Stamina}");
                }
                else
                {
                    Recharge();
                }
            }
            else 
            {
                Print("you missed your chance by clicking the wrong button");
            }
        }

        public bool isAlive() => Health > 0;
        {
            bool alive = true;
            if (Health <= 0) 
            {
                alive = false;
            }
            return alive; 
        }

        public void Recharge()
        {
            Stamina = _initialstamina;
            Print($"stamina was too low, you spent your turn recharging it. {this.GetType().Name}'s stamina was restored to {_initialstamina}");
        }
    }
}
