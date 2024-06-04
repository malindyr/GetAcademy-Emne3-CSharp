using System.Collections.Generic;

class ZooProgram
{
    /*//dyreprogram klasse
 printInfo (all animals)
seachAnimal method*/

   public List <Animal> Animals { get; private set; }

    public ZooProgram()
    {
        Animals = new List<Animal>
        {
        new Animal("Per", "frog", 3),
        new Animal("Ove", "cat", 4),
        new Animal("Gerda","horse", 3),
        new Animal("Frida","dog", 3),
        new Animal("Ole","frog", 3),
        new Animal("Arne","car", 3),
        new Animal("Ida","horse", 3),
        new Animal("Margot","dog", 3),
        new Animal("Vegar","horse", 3),
        new Animal("Bjørnar","dog", 3),
        };
    }

    public void PrintAllInfo()
    {
        foreach (var animal in Animals)
        {
            Console.WriteLine($"\r\n animal name: {animal.Name} \r\n animal species: {animal.Species} \r\n animal age: {animal.Age}");
        }
    }

    public void LookForSpecies()
    {
        var answer = Console.ReadLine();
        var foundspecies = new List<Animal>();

        for(int i=0; i<Animals.Count; i++)
        {
            if (Animals[i].Species == answer)
            {
                foundspecies.Add(Animals[i]);
            }
        }

        if(foundspecies.Count == 0)
        {
            Console.WriteLine("no");
        }
        else
        {
            foreach(var animal in foundspecies)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }

   /* public void LookForSpecies()
    {
        var answer = Console.ReadLine();
        var foundSpecies = new List<Animal>();

        for (int i = 0; i < Animals.Count; i++)
        {
            if (Animals[i].Species == answer)
            {
                foundSpecies.Add(Animals[i]);
            }
        }

        if (foundSpecies.Count == 0)
        {
            Console.WriteLine("Species not found or invalid input.");
        }
        else
        {
            foreach (var animal in foundSpecies)
            {
                Console.WriteLine($"{animal.Name}, {animal.Species}, {animal.Age}");
            }
        }
    }*/

    // søk skal ta vare på brukerens inpur og så vise de dyrene av arten brukeren etterspør. 
}