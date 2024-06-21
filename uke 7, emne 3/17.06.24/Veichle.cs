using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._06._24
{
    //such as has wheels, can be driven, has a maximum speed, etc.
    internal class Veichle
    {
        public string Name { get; set; }
        public int HasWheels { get; set; }
        public bool CanBeDriven { get; set; }
        public int HasMaximumSpeed { get; set; }

        public Veichle(int hasWheels, bool canBeDriven, int hasMaximumSpeed, string name)
        {
            Name = name;
            HasWheels = hasWheels;
            CanBeDriven = canBeDriven;
            HasMaximumSpeed = hasMaximumSpeed;
        }

        public Veichle(int hasWheels, bool canBeDriven, int hasMaximumSpeed)
        {
            HasWheels = hasWheels;
            CanBeDriven = canBeDriven;
            HasMaximumSpeed = hasMaximumSpeed;
            Name = this.GetType().Name;
        }

        public virtual void DisplayVeichle()
        {
            Console.WriteLine($"number of wheels: {HasWheels}, can be driven?: {CanBeDriven}, maximum speed: {HasMaximumSpeed}");
        }
        public Veichle NewVeichle()
        {
            bool allAnswers = false;
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
                    HasWheels = answerResult1;
                    CanBeDriven = answer2;
                    HasMaximumSpeed = answerResult3;
                    Name = answer4;
                    allAnswers = true;
                }
                else
                {
                    Console.WriteLine("please enter valid answers");
                }
            }

            return new Veichle(HasWheels, CanBeDriven, HasMaximumSpeed, Name);
        }
        
    }
}
