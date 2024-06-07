using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekkrutering_moodle__06._06._24__
{
    internal class Car : Veichle
    {
        public string _maxSpeed { get; private set; }
        public string _color { get; private set; }
        public string _type { get; private set; }

        public Car(string registration, string effect, string maxSpeed, string color, string type) : base()
        {
            _registration = registration;
            _effect = effect;
            _maxSpeed = maxSpeed;
            _color = color;
            _type = type;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"max speed: {_maxSpeed}, color: {_color}, type: {_type} \r\n");
        }

    }
}
