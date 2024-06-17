using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BattleSimulator___inheritance__09._06._24_
{
    internal class GameCharacterBase
    {
        public int Strength { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        private int _InitialStamina { get; set; }

        public GameCharacterBase(int strength, int health, int stamina)
        {
            Strength = strength;
            Health = health;
            Stamina = stamina;
            _InitialStamina = Stamina;
        }

        public void Print(string text) => Console.WriteLine(text);

        public bool IsAlive => Health > 0;

        public virtual void Fight(GameCharacterBase opponent)
        {
            if (Stamina >= 10)
            {
                opponent.Health -= this.Strength;
                Stamina -= 10;
                Print($"{this.GetType().Name} hit {opponent.GetType().Name} with {this.Strength} strength! {opponent.GetType().Name}'s health is now at {opponent.Health}");
                Print($"After the hit, {this.GetType().Name}'s stamina is: {this.Stamina}");
            } else
            {
                Recharge();
            }

        }

        public void Recharge()
        {
            Stamina = _InitialStamina;
            Print($"{this.GetType().Name}'s stamina was too low to strike. Stamina is now charged to {this._InitialStamina}");
        }
    }
}
