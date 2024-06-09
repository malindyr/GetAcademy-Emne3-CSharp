// See https://aka.ms/new-console-template for more information
using BattleSimulator___inheritance__09._06._24_;

Console.WriteLine("Hello, World!");

GameCharacterBase BMO = new BMO(10, 100, 30);

GameCharacterBase LemonGrab = new LemonGrab(0, 100, 20);


while (BMO.IsAlive && LemonGrab.IsAlive)
{

    BMO.Fight(LemonGrab);

    if(BMO.IsAlive && LemonGrab.IsAlive)
    {
        LemonGrab.Fight(BMO);
    }  
}

GameCharacterBase Winner = BMO.IsAlive ? BMO : LemonGrab;

Console.WriteLine($"{Winner.GetType().Name} is the winner!");

