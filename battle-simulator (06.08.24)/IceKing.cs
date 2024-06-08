using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battle_simulator__06._08._24_
{
    internal class IceKing : ICharacter
    {
        public int Stamina { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int _initialstamina { get; set; }

        public IceKing(int stamina, int health, int strength)
        {
            Stamina = stamina;
            Health = health;
            Strength = strength;
            _initialstamina = stamina;          
        }
        public static void Print(string textLine)
        {
            Console.WriteLine(textLine);
        }
        public void randomStrength()
        {
            Random rand = new Random();
            Strength = rand.Next(0,50);
        }
        public void Fight(ICharacter opponent)
        {
            if (Stamina >= 10)
            {
                randomStrength();
                opponent.Health -= Strength;
                Print($"{this.GetType().Name} hit {opponent.GetType().Name} with {this.Strength}! {opponent.GetType().Name}'s health is now at {opponent.Health}");
                Stamina -= 10;
            }
            else Recharge();
        }
        public bool isAlive() => Health > 0; //expression-bodied member (arrow function sounds cooler)

        public void Recharge()
        {
            Stamina = _initialstamina;
            Print($"{this.GetType().Name}'s stamina was too low to strike and they spent their turn recharging it. {this.GetType().Name}'s stamina was restored to {_initialstamina}");
        }
    }
}
