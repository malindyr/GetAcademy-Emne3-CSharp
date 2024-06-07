using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekkrutering_moodle__06._06._24__
{
    class Veichle
    {
        public string _registration {  get; set; }
        public string _effect { get; set; }

        public virtual void Run()
        {
            Console.WriteLine("driving...");
        }

        public virtual void PrintInfo() {

            Console.WriteLine($"Veichle type {this.GetType().Name}, registration: {_registration}, effect: {_effect}, ");
        }

        public virtual bool CheckIfSame(Veichle veichleInQuestion)
        {
            if (veichleInQuestion == this)
            {
                Console.WriteLine("the cars are alike");
                return true;
            }
            else
            {
                Console.WriteLine("the cars are not alike");
                return false;
            }

        }
    }
}
