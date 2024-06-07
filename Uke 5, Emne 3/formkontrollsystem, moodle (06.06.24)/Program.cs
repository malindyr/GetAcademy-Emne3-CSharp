/*Oppgave: Formkontrollsystem
Ditt oppdrag er å lage et enkelt system for håndtering av ulike former (shapes) ved hjelp av arv i C#.


Del 2: Hovedprogram (Main)


I hovedprogrammet, gjør følgende:

Opprett en liste av Form-objekter.
Legg til minst to instanser av hver formtype (sirkel, rektangel, trekant) i listen.
Gå gjennom listen og skriv ut informasjon om hver form, inkludert navn, farge og beregnet areal.


Del 3: Ekstra funksjonalitet


Totalt Areal:

Implementer en metode i hovedprogrammet for å beregne og skrive ut det totale arealet av alle formene i listen.


Sortering:

Implementer en metode for å sortere formene i listen basert på areal (fra lavest til høyest).


Fargefiltrering:

Implementer en metode for å filtrere formene i listen basert på farge og skrive ut resultatet.
*/

using System;
using System.Drawing;

using formkontrollsystem__moodle__06._06._24_;

Shape triangle1 = new Triangle("triangle1", Color.Plum ,20,20);
Shape triangle2 = new Triangle("triangle2", Color.Pink, 34, 23);

triangle1.CalculateArea();
triangle2.CalculateArea();

Shape circle1 = new Circle("circle1", Color.Magenta, 20);
Shape circle2 = new Circle("circle2", Color.Plum, 20);

circle1.CalculateArea();
circle2.CalculateArea();

Shape rectangle1 = new Rectanglez("rectangle1", Color.AliceBlue, 20, 30);
Shape rectangle2 = new Rectanglez("rectangle2", Color.DeepPink, 15, 30);

rectangle1.CalculateArea();
rectangle2.CalculateArea();

List<Shape> ShapeList = new List<Shape>() { triangle1, triangle2, circle1, circle2, rectangle1, rectangle2 };


AreaOfAllshapes();
void AreaOfAllshapes()
{
    foreach (Shape shape in ShapeList)
    {
        Console.WriteLine($"Shape name: {shape._name}, Color: {shape.Color}, Area: {shape.CalculateArea()} \r\n");
    }
}

List<Shape> sortedShapes = SortShapesByArea(ShapeList);

Console.WriteLine("Shapes sorted by area (lowest to highest):");

static List<Shape> SortShapesByArea(List<Shape> shapes)
{
    return shapes.OrderBy(shape => shape.CalculateArea()).ToList();
}

foreach (Shape shape in sortedShapes)
{
    Console.WriteLine($"{shape._name} - Area: {shape.CalculateArea()}");
}



List<Shape> sortedByColor = SortShapesByColor(ShapeList);

static List<Shape> SortShapesByColor(List<Shape> shapeList)
{
    return shapeList.OrderBy(shape => shape.Color.Name).ToList();
}

foreach(Shape shape in sortedByColor)
{
    Console.WriteLine($"{shape._name}, {shape.Color}");
}