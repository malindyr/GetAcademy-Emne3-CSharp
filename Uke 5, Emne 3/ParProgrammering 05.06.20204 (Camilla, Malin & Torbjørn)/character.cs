
using PPHogwarts.Store;

namespace PPHogwarts
{
    internal class Character
    {
        private string _name { get; set; }
        private string _house { get; set; }
        private Wand _wand { get; set; }
        private Animal _animal { get; set; }

        public Character(string name, string house)
        {
            _name = name;
            _house = house;
            _wand = null;
            _animal = null;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Hello, \r\n name: {_name} \r\n house: {_house}");

            if (_wand != null)
            {
                Console.WriteLine(_wand.GetType().Name);
            } else if (_animal != null)
            {
                Console.WriteLine(_animal.GetType().Name);
            }
        }

     


        public void Buy()
        {

            Console.WriteLine("would you like to buy a wand or animal? \r\n" +
                "1. Wand \r\n" +
                "2. Animal");

            if(int.TryParse(Console.ReadLine(), out int answer))
            {
                if(answer == 1)
                {

                }
            }

            

            



            /*/*Karakteren skal ha mulighet til å gå inn i en Magibutikk, der kan de kjøpe et dyr:  ugle,rotte eller en katt. 
        De har også mulighet til å kjøpe en tryllestav: føniksstav, unikornstav eller trollstav. 
        For å få til dette må du lage en egen klasse som er butikken, og presentere brukeren med en meny for hva personen skal kjøpe.*/

        }

        public void CastSpell()
        {
            /*Karakteren skal ha mulighet til å trylle - ta inn input fra brukeren, 
            og dersom en skriver en riktig trylleformel skal det printes til skjermen at de har utført tryllingen
            trylleformler: 
            vingardium leviosa (får en fjær til å fly)
            hokus pokus (fyrer av fyrverkerier)*/

        }




    }

    }
