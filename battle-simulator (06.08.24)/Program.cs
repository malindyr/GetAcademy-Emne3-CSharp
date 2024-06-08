/*Ta inspirasjon fra en film, spill o.l. og velg en hovedperson (helten) og en motspiller (den slemme). 
 * Helten blir spilt av deg med bruk av Console.ReadLine, mens motparten blir spilt av dataen. 

Lag 2 klasser, en til hver av karakterene, og gi dem det nødvendige 
(health, mana, stamina, backpack? etc) og generer en av hver i en metode som for eksempel heter Start();
Her må du finne ut av hvordan hver og enkelt kan utføre en oppgave, 
når fienden skal angripe eller generere stamina etc. Bruk av random kan være en løsning. 

Trenger man en egen klasse for alt det fienden skal kunne gjøre? Trenger man en egen klasse for valgene man skal gjøre med hovedpersonen? 
Skal man ha mulighet for å heale? 
Dette er det du som bestemmer ;) Jo mer du skriver, jo mer innser man hvor ting burde stå.*/


using battle_simulator__06._08._24_;

var mainCharacter = new Finn(30, 30, 10);
var opponent = new IceKing(20, 30, 0);

ICharacter winner = null;
bool IsEveryoneAlive() => mainCharacter.isAlive() && opponent.isAlive();

while (IsEveryoneAlive())
{
    mainCharacter.Fight(opponent);

    if(IsEveryoneAlive())
    opponent.Fight(mainCharacter);
}

winner = (mainCharacter.isAlive() ? mainCharacter : opponent);
Console.WriteLine($"{winner.GetType().Name} is the winner");

