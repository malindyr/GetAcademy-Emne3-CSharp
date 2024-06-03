 class GameCharacter
{
    public int Health { get; private set; }
    public int Strength { get; private set; }
    public int Mana { get; private set; }

    private int InitMana { get; set; }

    public GameCharacter(int health, int strength, int mana)
    {
        Health = health;
        Strength = strength;
        Mana = mana;
        InitMana = mana;
    }

    public void Attack(GameCharacter opponent) //boss.fight(hero), hero is the "opponent"
    {
        if (Mana > 0)
        {
            opponent.Health -= this.Strength;
            Mana -= 10;     //GetType(): method is called on "this" and it returns the type(class) of the current instance.
            Console.WriteLine($"{this.GetType().Name} hit {opponent.GetType().Name} with {this.Strength}. {opponent.GetType().Name} health is now {opponent.Health}\r\n");
        }                          //"the exact runtime type of the current instance"
        else
        {
            Console.WriteLine($"stamina was too low, {this.GetType().Name} had to recharge\r\n");
            Regenerate();
        }
    }


    public void Regenerate()
    {
        Mana = InitMana;
        Console.WriteLine($"{this.GetType().Name}'s mana is now back at {Mana}");
    }

    protected void EditStrength( int newStrength) {
        Strength = newStrength;
    }

    public void Whowon(GameCharacter opponent)
    {
        GameCharacter winner = null;
        if(Health > opponent.Health) {
            winner = this;
        }
        else { winner = opponent; }

        Console.WriteLine($"{winner.GetType().Name} is the winner!");

    }
    

}


/*Attack(): Simulates an attack and reduces the opponent's health by the character's strength. Reduces the character's mana by 10.
Regenerate(): Restores the character's mana to its initial value.*/


//Requirements:
//Class GameCharacter:

//Properties: Health, Strength, Mana