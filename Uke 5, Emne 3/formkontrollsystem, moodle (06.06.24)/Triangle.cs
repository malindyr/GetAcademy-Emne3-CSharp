using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formkontrollsystem__moodle__06._06._24_
{

    /*

Trekant (Triangle):

Arver fra Form.
Egenskaper: Base, Høyde.
Implementer metoden BeregnAreal() for å beregne arealet av trekanten.*/
    internal class Triangle : Shape
    {
        public int _base {  get; set; }
        public int _height { get; set; }

        public Triangle(string name, Color color, int @base, int height ) : base(name, color) {

            _base = @base;
            _height = height;
        
        }

        public override double CalculateArea()
        {
            var Area = 0.5 * _base * _height;
            return Area;
        }
    }
}
