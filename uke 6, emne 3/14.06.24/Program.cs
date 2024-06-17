/*
 * Du skal lage en oppskriftsapp der brukeren kan velge å:
Se alle oppskrifter som er tilgjengelig,
Filtrere oppskrift basert på kategori; ex vegetar, helgekos,
Filtrere oppskriftene ved å søke etter oppskrifter som inneholder en spesifikk ingrediens
Brukeren skal kunne velge å se nærmere på en oppskrift for å få ingredienser og fremgangsmetode


//app klasse
//oppskrift

*/


using _14._06._24;

App app = new App();

Recipe Pizza = new Recipe("Pizza", "Italian", "make pizza", new List<string>() { "egg", "flour" });
Recipe Taco = new Recipe("Taco", "Italian", "make pizza", new List<string>() { "egg", "flour"});



app.AddRecipe(Pizza);
app.AddRecipe(Taco);

Pizza.AddIngredient("egg");
Pizza.AddIngredient("melk");
Pizza.AddIngredient("flour");




//Pizza.DisplayRecipe();

//app.SearchForRecipe("egg");

app.SearchForRecipe("egg");


