using System;

namespace Clicker
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new ClickerGame();
            var commands = new Commands(game);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Kommandoer:\r\n - SPACE = klikk (og få poeng)\r\n - K = kjøp oppgradering \r\n       øker poeng per klikk \r\n       koster 10 poeng\r\n - S = kjøp superoppgradering \r\n       øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       koster 100 poeng\r\n - X = avslutt applikasjonen");
                Console.WriteLine($"Du har {game.Points} poeng.");
                Console.WriteLine("Trykk tast for ønsket kommando.");
                var command = Console.ReadKey().KeyChar;
                commands.Run(command);
            }
        }
    }
}
/*int points = 0;
int pointsPerClick = 1;
int pointsPerClickIncrease = 1;

while (true)
{
    Console.Clear();
    Console.WriteLine("Kommandoer:\r\n" +
   "- SPACE = klikk(og få poeng)\r\n" + 
   "- K = kjøp oppgradering \r\nøker poeng per klikk koster 10 poeng \r\n" + 
   "- S = kjøp superoppgradering øker poeng per klikk for den vanlige oppgraderingen. koster 100 poeng\r\n" + 
   "- X = avslutt applikasjonen");

    Console.WriteLine($"Du har {points} poeng.");
    Console.WriteLine("Trykk tast for ønsket kommando.");


    var command = Console.ReadKey().KeyChar;
    if (command == 'x') Environment.Exit(0);
    else if (command == ' ') points += pointsPerClick;
    else if (command == 'k' && points >= 10)
    {
        points -= 10;
        pointsPerClick += pointsPerClickIncrease;
    }
    else if (command == 's' && points >= 100)
    {
        points -= 100;
        pointsPerClickIncrease++;
    }
}*/

/*Skriv om til mer objektorientert ved å innføre en klasse ClickerGame med 
 * objektvariabler for de tre int-variablene og en metode for hver kommando. 
 * Innfør også et interface ICommand med kun én metode, Run. Lag så en klasse 
 * for hver kommando i applikasjonen. Lag også en egen klasse CommandSet. 
 * Denne har en array med et objekt av hver kommando. Når brukeren taster et tegn, 
 * skal dette sendes til metoden RunCommand i CommandSet. 
 * Der slår den opp hvilken kommando som har den aktuelle bokstaven og kjører så Run på denne kommandoen.*/


//clickergame klasse

//* objektvariabler for de tre int-variablene
// get; set; for x, ' ' , k
//
//og en metode for hver kommando.
//' ' = points += pointsPerClick
//k = command == 'k' && points >= 10)  points -= 10; pointsPerClick += pointsPerClickIncrease
//s = command == 's' && points >=100, points-=100 pointsPerCliskIncrease++
//x = environment.exit

//