/*Create a console app that simulates a battle between a Wizard and a Dragon.

Requirements:
Class GameCharacter:

Properties: Health, Strength, Mana
Methods:
Attack(): Simulates an attack and reduces the opponent's health by the character's strength. Reduces the character's mana by 10.
Regenerate(): Restores the character's mana to its initial value.
Derived Classes:

Wizard (inherits from GameCharacter)
Dragon (inherits from GameCharacter)
Initialization:

Wizard:
Health: 150
Strength: 25
Mana: 50
Dragon:
Health: 300
Strength: 0-50 (random value for each attack)
Mana: 20
Battle Simulation:

Both characters fight until one of their health reaches 0.
Log each attack, damage dealt, and remaining health.
Characters lose mana with each attack. If mana is 0, they must use Regenerate() in the next turn.
Example Console Log:
csharp
Kopier kode
Dragon hit wizard with 30 damage, wizard now has 120 health left.
Wizard hit dragon with 25 damage, dragon now has 275 health left.
Dragon hit wizard with 45 damage, wizard now has 75 health left.
Wizard is out of mana and regenerates.
Dragon hit wizard with 10 damage, wizard now has 65 health left.
Wizard hit dragon with 25 damage, dragon now has 250 health left.
...
Wizard hit dragon with 25 damage, dragon now has 0 health left.
Wizard is the winner!
Additional Challenge:
Add a special ability for each character that can be used once when their health drops below 50%:
Wizard: Fireball(): Deals 50 damage to the dragon but uses 20 mana.
Dragon: FlameBreath(): Deals 70 damage to the wizard but uses 15 mana.
This assignment will help you practice object-oriented programming, inheritance, and handling random values in C#. Good luck, and have fun coding!

*/

Wizard wizard = new Wizard();
Dragon dragon = new Dragon();

GameCharacter Winner = null;
while (wizard.Health >= 0 && dragon.Health >= 0) {  

wizard.Attack(dragon);

dragon.RandomStrength();
dragon.Attack(wizard);

}

wizard.Whowon(dragon);

