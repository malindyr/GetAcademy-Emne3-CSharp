using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekkrutering_moodle__06._06._24__
{
    internal class Boat : Veichle
    {
        public string _maxSpeed {  get; set; }
        public string _grossTonnage { get; set; }
        public Boat(string registration, string effect, string maxSpeed, string grossTonnage) : base(){ 

            _registration = registration;
            _effect = effect;
            _maxSpeed = maxSpeed;
            _grossTonnage = grossTonnage;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"max speed: {_maxSpeed}, gross tonnage: {_grossTonnage} \r\n");
        }

    }
}
