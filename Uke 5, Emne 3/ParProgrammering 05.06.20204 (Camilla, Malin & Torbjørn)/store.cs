

using ParProgrammering_05._06._20204__Camilla__Malin___Torbjørn_;

namespace PPHogwarts.Store
{
    internal class Store { 
        private List<Wand> WandsInStock { get; }
        private List<Animal> AnimalsInStock { get; }
        public Store()
        {

            WandsInStock = new List<Wand>()
            {
                new Wand{ProductName = "Phoenix Wand", ProductPrice = 4000 },
                new Wand{ProductName = "Unicorn Wand", ProductPrice = 5000 },
                new Wand{ProductName = "Troll Wand", ProductPrice = 3500 },
            };

            AnimalsInStock = new List<Animal>()
            {
                new Animal{ProductName = "Owl", ProductPrice = 400},
                new Animal{ProductName = "Cat", ProductPrice = 300},
                new Animal{ProductName = "Rat", ProductPrice = 200},
            };
        }
        public List<Product> DisplayItems()
        {
            int i = 0;
            bool Answered = false;
            Product ChosenProduct = null;

                Console.WriteLine("would you like to buy a wand or animal? \r\n" +
                    "1. Wand \r\n" +
                    "2. Animal");

            while (!Answered)
            {
                if (int.TryParse(Console.ReadLine(), out int answer))
                {
                    if (answer == 1)
                    {
                        return WandsInStock;
                        Answered = true;                                  
                    }
                    else if (answer == 2)
                    {
                        return Animal;
                        Answered = true;               

                    }
                }
            }
        }
    }
}