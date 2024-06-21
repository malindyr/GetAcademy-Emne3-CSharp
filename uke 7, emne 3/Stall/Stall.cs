using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stall
{
    ///*Du skal lage en stall, den skal ha noen hester. Hestene kan løpe i forskjellige hastigheter,
    internal class Stable
    {
        private List<Hest> HesterIStallen { get; set; }


        public Stable(List<Hest> HesteListe)
        {
            HesterIStallen = HesteListe;
        }

        /*Under et hesteløp kan man ha en løkke
         (for enkelhetsskyld kan hver runde i løkken tilsvare 1 time) som går frem til en av hestene har vunnet.
           En hest skal løpe 3000km. Print ut hvor langt hestene har løpt per runde i løkken. /*/

        //hver runde 1 t
        //avstand løpt per runde
        //

        public void Meny()
        {
            while (true)
            {
                Console.WriteLine(
                    "Velkommen til stallen! hva vil du gjøre? \r\n 1. Mat en hest, \r\n 2. stell en hest \r\n 3. hesteløp");

                var Answer = int.TryParse(Console.ReadLine(), out int Number);

                if (Answer)
                {
                    if (Number == 1)
                    {
                        Console.WriteLine("Hvilken hest vil du mate?");
                        var ValgtHest = FinnHesten();
                        ValgtHest.MatHest();
                    }
                    else if (Number == 2)
                    {
                        Console.WriteLine("hvilken hest vil du stelle?");
                        var ValgtHest = FinnHesten();
                        ValgtHest.StellHest();
                    } 
                    else if (Number == 3)
                    {
                        HesteLøp();
                    }
                }
                else
                {
                    Console.WriteLine("skriv inn ett tilsvarende tall");
                }
            }
        }


        public Hest FinnHesten()
        {
            foreach (var hest in HesterIStallen)
            {
                Console.WriteLine($" {hest.Navn}");
            }

            Hest ValgtHest = null;

            while (ValgtHest == null)
            {
                var HesteSvar = Console.ReadLine();

                ValgtHest = HesterIStallen.FirstOrDefault(hest => hest.Navn == HesteSvar);

                if (ValgtHest != null)
                {
                    Console.WriteLine(ValgtHest.Navn);
                }
                else
                {
                    Console.WriteLine("kunne ikke finne hesten din, prøv igjen");
                }
            }
            return ValgtHest;
        }

        public void HesteLøp()
        {
            int Goal = 3000;
            int avstandLøpt = 0;
            bool HarVunnet = false;

            while (!HarVunnet)
            {
                foreach (var hest in HesterIStallen)
                {
                    if (hest.AvstandLøpt >= Goal)
                    {
                        HarVunnet = true;
                    }
                    hest.Løp();
                }
            }

            var vinner = HesterIStallen.FirstOrDefault(hest => hest.AvstandLøpt >= Goal);

            Console.WriteLine($"vinneren er: {vinner.Navn}");

        }


    }
}
