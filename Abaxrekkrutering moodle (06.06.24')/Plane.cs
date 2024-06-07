using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekkrutering_moodle__06._06._24__
{
    internal class Plane : Veichle
    {
        public string _wingspan {  get; set; }
        public string _loadCapacity { get; set; }
        public string _weigth { get; set; }
        public string _class { get; set; }

        public Plane(string registration, string effect, string wingspan, string loadCapacity, string weigth, string @class) : base()
        {
            _registration = registration;
            _effect = effect;
            _wingspan = wingspan;
            _loadCapacity = loadCapacity;
            _weigth = weigth;
            _class = @class;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"wing span: {_wingspan}, load capacity: {_loadCapacity}, weight: {_weigth}, class: {_class} \r\n");
        }

        public override void Run() {

            Console.WriteLine("flying...");
        }
    }
}
