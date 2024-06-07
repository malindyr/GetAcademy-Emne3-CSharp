using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formkontrollsystem__moodle__06._06._24_
{
    /*Rektangel (Rectangle):

Arver fra Form.
Egenskaper: Lengde, Bredde.
Implementer metoden BeregnAreal() for å beregne arealet av rektangelet.*/

    internal class Rectanglez : Shape
    {
        public int _length {  get; set; }
        public int _width { get; set; }

        public Rectanglez(string name, Color color, int length, int width) : base(name, color)
        {
            _length = length;
            _width = width;
        }

        public override double CalculateArea()
        {
            var Area = _length * _width;
            return Area;

        }
    }
}
