
/* Lag noen forskjellige items for å sjekke at det fungerer som tenkt.*/

using Par_Programmering__Malin___Araz__13._06._24;

ClothingItem ClothingItem1 = new ClothingItem("bukse", 1, 100.50, "s", "blue");
ClothingItem ClothingItem2 = new ClothingItem("topp", 1, 200, "xs", "pink");

//ClothingItem1.DisplayInfo();

//ClothingItem1.CalculatePrice();




ElectronicItem ElectronicItem1 = new ElectronicItem("Ipad", 1, 1055.26, "standard insurance", "12v");
ElectronicItem ElectronicItem2 = new ElectronicItem("Samsung phone", 1, 3000, "standard insurance", "13v");

//ElectronicItem1.DisplayInfo();

//ElectronicItem1.CalculatePrice();


Store TheStore = new Store();

TheStore.AddItem(ClothingItem1);
TheStore.AddItem(ClothingItem2);
TheStore.AddItem(ElectronicItem1);
TheStore.AddItem(ElectronicItem2);

TheStore.ListItemsByPrice();

//Console.WriteLine(TheStore.FindItemInTheBack());

Customer customer = new Customer(3000);

//customer.BuyItem(ClothingItem1);




/*Lag en base klasse som heter “InventoryItem” 
 * hvor du har info om itemets navn, antall og pris. 
 * Lag to klasser til, ClothingItem og ElectronicItem. 
 * Disse skal ha informasjon om størrelse og farge 
 * f.eks på klær og f.eks forsikringsinformasjon og spenning på det elektriske. 
 * La disse klassene arve av baseklassen, slik at de også får bruke navn, antall og pris. 
 * Lag et interface ISellable som har en funksjon som kalkulerer pris, 
 * kanskje nettbutikken har black friday salg og det er 30% rabatt på alle varer? 
 * Eller man må legge på skatt for varene?. Implementer dette interfacet i ClothingItem og ElectronicItem
Lag noen forskjellige items for å sjekke at det fungerer som tenkt.*/