using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace formkontrollsystem__moodle__06._06._24_
{
    internal abstract class Shape
    {
        /*
Form (Shape):

En abstrakt klasse som representerer en generell form.
Egenskaper: Navn, Farge.
Metode: BeregnAreal() skal være abstrakt og returnere arealet av formen.*/

        public string _name {  get; set; }
        public Color Color { get; set; }

        public abstract double CalculateArea();

        protected Shape(string name, Color color)
        {
            _name = name;
            Color = color;
        }

    }
}
