/*Du skal lage en stall, den skal ha noen hester. Hestene kan løpe i forskjellige hastigheter,
feks 20km/h, 30km/h og 35km/h. Du skal kunne mate hesten, stelle med hesten og hesten skal kunne meldes på hesteløp. 

Under et hesteløp kan man ha en løkke (for enkelhetsskyld kan hver runde i løkken tilsvare 1 time) som går frem til en av hestene har vunnet.
En hest skal løpe 3000km. Print ut hvor langt hestene har løpt per runde i løkken.*/


using Stall;

Stable stall = new Stable(new List<Hest>()
{
    new Hest("Pia", 5, 5, 25), 
    new Hest("Kåre", 5, 5, 30),
    new Hest("Svein", 5, 5, 35),
    new Hest("Berit", 5, 5, 35),
});

stall.Meny();


