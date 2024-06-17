using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._06._24
{
    //Filtrere oppskrift basert på kategori; ex vegetar, helgekos,

    //Brukeren skal kunne velge å se nærmere på en oppskrift for å få ingredienser og fremgangsmetode
    internal class Recipe
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Instructions { get; set; }
        public List<string> Ingredients { get; set; }
        

        public Recipe(string name, string category, string instructions, List<string> ingredients)
        {
            Name = name;
            Category = category;
            Instructions = instructions;
            Ingredients = ingredients;

        }

        public void AddIngredient(string ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public void DisplayRecipe()
        {
            var IngredientListString = "";
            foreach (var ingredient in Ingredients)
            {
                IngredientListString += ingredient + ", ";
            }

            Console.WriteLine($"Recipe for {Name}. Instructions: {Instructions}, Ingredients: {IngredientListString}");
        }
    }
}
