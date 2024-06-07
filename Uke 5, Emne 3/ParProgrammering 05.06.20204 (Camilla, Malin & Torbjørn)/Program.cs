/*Harry Pottah🥳l33t haxx0r

Karakteren skal ha mulighet til å trylle - ta inn input fra brukeren, 
og dersom en skriver en riktig trylleformel skal det printes til skjermen at de har utført tryllingen
trylleformler: 
vingardium leviosa (får en fjær til å fly)
hokus pokus (fyrer av fyrverkerier)*/


using PPHogwarts;
using PPHogwarts.Store;

var TheStore = new Store();

var HarryPotter = new Character("Harry", "Gryffindor");
HarryPotter.PrintInfo();


    Console.WriteLine("Press the corresponding number with the task on the menu" +
        "\r\n 1. Buy Animal/Wand" +
        "\r\n 2. Cast Spell" +
        "\r\n 3. Exit");



    if (int.TryParse(Console.ReadLine(), out int Answernumber))
    {
        if (Answernumber == 1)
        {
            TheStore.DisplayItems();
            HarryPotter.Buy();
    }
        else if (Answernumber == 2)
        {
            HarryPotter.CastSpell();
        }
        else if (Answernumber == 3)
        {
            Environment.Exit(0);
        }

    }


