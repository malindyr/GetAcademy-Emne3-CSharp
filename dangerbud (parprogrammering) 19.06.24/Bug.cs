using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dangerbud__parprogrammering__19._06._24
{
    // Lag en baseklasse som heter “bug” og la de andre insektsypene arve hovedegenskapene til insekter fra denne (kan bite, har bein, kan bevege seg f.eks:) )
    internal class Bug
    {
        public string Name { get; set; }
        public bool CanBite { get; set; }
        public int NumberOfLegs { get; set; }
        public string WayOfMoving { get; set; }

        public string WayOfBeingAnnoying { get; set; }

        public Bug(string name, bool canBite, int numberOfLegs, string wayOfMoving, string wayOfBeingAnnoying)
        {
            Name = name;
            CanBite = canBite;
            NumberOfLegs = numberOfLegs;
            WayOfMoving = wayOfMoving;
            WayOfBeingAnnoying = wayOfBeingAnnoying;
        }

        public void DisplayBug()
        {
            Console.WriteLine($"\r\nbug name: {Name} \r\n , can bite?: {CanBite}, number of legs: {NumberOfLegs}, way of moving: {WayOfMoving}, way of being annoying: {WayOfBeingAnnoying} \r\n");
        }


    }
}
