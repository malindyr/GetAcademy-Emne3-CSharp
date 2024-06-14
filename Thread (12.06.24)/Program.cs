using System;
using System.Threading;

bool isMenuActive = false;

while (true) //forever loop checking for key press
{
    // Check for key press to trigger the menu
    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey(true).Key; //it's like asking the computer: "Hey, is it true? Is there a key that someone pressed on the keyboard?"
        /*"If it's true that you pressed a key (like '6'), I will not show that key on the screen immediately. 
         *Instead, I'll keep it a secret and let the program decide what to do with it."*/

        if (key == ConsoleKey.D6)
        {
            isMenuActive = true;
            ShowMenu();
        }
    }

   
    if (!isMenuActive) //if the menu is active, game will not run
    {
        RunGameLogic();
    }

}

void RunGameLogic()
{
  
}

void ShowMenu()
{
    while (isMenuActive)
    {
        Console.Clear();
        Console.WriteLine("Game Menu:");
        Console.WriteLine("1. Option 1");
        Console.WriteLine("2. Option 2");
        Console.WriteLine("3. Option 3");
        Console.WriteLine("0. Return to Game");

        var choice = Console.ReadKey(true).Key;
        switch (choice)
        {
            case ConsoleKey.D1:
                Console.WriteLine("Option 1 selected");
                Thread.Sleep(1000);
                break;
            case ConsoleKey.D2:
                Console.WriteLine("Option 2 selected");
                Thread.Sleep(1000);
                break;
            case ConsoleKey.D3:
                Console.WriteLine("Option 3 selected");
                Thread.Sleep(1000); 
                break;
            case ConsoleKey.D0:
                isMenuActive = false;
                Console.Clear();
                Console.WriteLine("Returning to game...");
                Thread.Sleep(1000); 
                break;
            default:
                Console.WriteLine("Invalid option. Try again.");
                Thread.Sleep(1000); 
                break;
        }
    }
}