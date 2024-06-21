using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dangerbud__parprogrammering__19._06._24
{
    internal class MyBugs
    { 
        public List<Bug> AllBugs { get; set; }
        public List<Bug> AddedBugs { get; set; }

        public MyBugs()
        {
            AllBugs = new List<Bug>();
            AddedBugs = new List<Bug>()
            {
                new Mosqito(),
                new Wasp(),
                new Tick(),
                new Spider(),
                new Fly(),
        };
        }

        /* Start options i konsollen skal være 
           Se liste over insekter  -- her skal alle insektene listes opp, 
           og man skal kunne velge ett og gå inn å så på egenskapene dens (om den er farlig, plagende eller annet)
           Legge inn flere insekter*/
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine(
                    "what do you want to do? Press according number! \r\n 1. See all bugs \r\n 2. check out a specific bug, \r\n 3. Add a bug");
                var chosenOption = Console.ReadLine();

                if (chosenOption == "1")
                {
                    DisplayAllBugs();
                }
                else if (chosenOption == "2")
                {
                    CheckOutBug();
                }else if (chosenOption == "3")
                {
                    CreateNewBug();
                }
            }


        }
        public void AddNewBug(Bug MyNewBug)
        {
            AddedBugs.Add(MyNewBug);
            Console.WriteLine("would you like to see your added bugs? write yes to see bugs");
            var Answer = Console.ReadLine();

            if (Answer == "yes")
            {
                foreach (var bug in AddedBugs)
                {
                    bug.DisplayBug();
                }
            } else Console.WriteLine("you missed out on seeing some cool bugs");
        }

        public void CheckOutBug()
        {
            foreach (var bug in AllBugs)
            {
                Console.WriteLine($"\r\n {bug.Name}");
            }

            foreach (var bug in AddedBugs)
            {
                Console.WriteLine($"\r\n {bug.Name}");
            }
        }

        public void DisplayAllBugs()
        {
            foreach (var bug in AllBugs)
            {
                bug.DisplayBug();
            }
        }

        public void CreateNewBug()
        {
            bool areAllAnswers = false;
            while (areAllAnswers)
            {
                Console.WriteLine("whats the name of your bug?");
                string nameAnswer = Console.ReadLine();

                Console.WriteLine("can it bite? write yes if yes, anything else if no");
                var canBiteAnswer = Console.ReadLine() == "yes" ? true : false;

                Console.WriteLine("how many legs does it have?");
                var numberOfLegs = int.TryParse(Console.ReadLine(), out int numberOfLegsAnswer);

                Console.WriteLine("how does it move from one place to another?");
                var wayOfMovingAnswer = Console.ReadLine();

                Console.WriteLine("whats its flaw/way of being annoying?");
                var wayOfBeingAnnoying = Console.ReadLine();

                if (nameAnswer != null && numberOfLegs & wayOfMovingAnswer != null & wayOfBeingAnnoying != null)
                {
                    AddNewBug(new Bug(nameAnswer, canBiteAnswer, numberOfLegsAnswer, wayOfMovingAnswer, wayOfBeingAnnoying));
                    areAllAnswers = true;
                }
                else
                {
                    Console.WriteLine("please enter valid answers");
                }
            }
        }
    }
}
