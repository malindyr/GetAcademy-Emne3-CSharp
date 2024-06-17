using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._06._24
{
    //Filtrere oppskriftene ved å søke etter oppskrifter som inneholder en spesifikk ingrediens
    internal class App
    {
        public List<Recipe> Recipes {  get; set; }


        public App()
        {
            Recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
        }

        public void DisplayAllRecipes()
        {
            foreach (var recipe in Recipes)
            {
                recipe.DisplayRecipe();
            }
        }

        public void SearchForRecipe(string ingredient)
        {
           // List <Recipe> FoundRecipesList = new List<Recipe>();

            

            //var FoundRecipe = Recipes.FirstOrDefault(r => r.Ingredients.Contains(ingredient));

            //Console.WriteLine(FoundRecipe.Name);

            
            var FoundRecipeList = Recipes.Where(x => x.Ingredients.Contains(ingredient)).ToList();


            foreach (var recipe in FoundRecipeList)
            {
                Console.WriteLine(recipe.Name);
            }

            


            

            //FoundRecipesList.

    }

    }

   
}
