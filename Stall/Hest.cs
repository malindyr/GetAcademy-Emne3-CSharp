using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Stall
{
    //feks 20km/h, 30km/h og 35km/h. Du skal kunne mate hesten, stelle med hesten og hesten skal kunne meldes på hesteløp. 
    internal class Hest
    {
        public String Navn { get; set; }
        public int Mat { get; private set; }
        public int Stell { get; private set; }
        public int Hastighet { get; private set; }
        public int AvstandLøpt { get;  set; }

        public Hest(string navn, int mat, int stell, int hastighet)
        {
            Navn = navn;
            Mat = mat;
            Stell = stell;
            Hastighet = hastighet;
        }

        public void Løp()
        {
            AvstandLøpt += Hastighet;
            Console.WriteLine($"{Navn}'s avstand løpt er nå: {AvstandLøpt}");
        }

        public void MatHest()
        {
            Mat++;
            Console.WriteLine($"Du matet hesten din, {this.Navn}. mat nivå: {Mat}");
        }

        public void StellHest()
        {
            Stell++;
            Console.WriteLine($"du stelte med hesten din, {this.Navn}. stell nivå: {Mat}");
        }
    }
}
