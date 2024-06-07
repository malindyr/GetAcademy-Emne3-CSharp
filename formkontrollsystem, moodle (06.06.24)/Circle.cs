using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formkontrollsystem__moodle__06._06._24_
{
    /*Sirkel (Circle):

Arver fra Form.
Egenskap: Radius.
Implementer metoden BeregnAreal() for å beregne arealet av sirkelen.
*/
    internal class Circle : Shape
    {
        public int _radius {  get; set; }

        public Circle(string name, Color color, int radius) : base(name, color) {
            
            _radius = radius;

        }

        public override double CalculateArea()
        {
            var Area = Math.PI * _radius * _radius;

            return Area;
        }
    }
}
