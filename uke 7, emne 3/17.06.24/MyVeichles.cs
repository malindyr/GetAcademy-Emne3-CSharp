using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _17._06._24
{
    internal class MyVeichles
    {
        private List<Veichle> MyVeichlesList { get; set; }

        public MyVeichles()
        {
            MyVeichlesList = new List<Veichle>();
        }

        public void AddVeichle(Veichle veichleToAdd)
        {
            MyVeichlesList.Add(veichleToAdd);

            Console.WriteLine($"{veichleToAdd.Name} was added to your list of added veichles. Would you like to see the list? type 'yes'");

            var answer = Console.ReadLine() == "yes" ? true : false;

            if (answer)
            {
                foreach (var veichle in MyVeichlesList)
                {
                    Console.WriteLine($"Veichle: {veichle.Name}");
                    veichle.DisplayVeichle();
                }
            }
        }

        public void NewVeichle()
        {
            bool allAnswers = false;
            Veichle newVeichle = null;
            while (!allAnswers)
            {

                Console.WriteLine("how any wheels does your veichle have?");
                var answer1 = int.TryParse(Console.ReadLine(), out int answerResult1);

                Console.WriteLine("can your veichle be driven? yes, or any other answer for no.");
                var answer2 = Console.ReadLine() == "yes" ? true : false;

                Console.WriteLine("what kmh is your veichles maximum speed?");
                var answer3 = int.TryParse(Console.ReadLine(), out int answerResult3);

                Console.WriteLine("Enter a name for your veichle");
                var answer4 = Console.ReadLine();


                if (answer1 && answer3)
                {
                    var haswhels = answerResult1;
                    var CanBeDriven = answer2;
                    var HasMaximumSpeed = answerResult3;
                    var Name = answer4;

                    AddVeichle(new Veichle(haswhels, CanBeDriven, HasMaximumSpeed, Name));

                    allAnswers = true;
                }
                else
                {
                    Console.WriteLine("please enter valid answers");
                }
            }
            
        }
    }

}
