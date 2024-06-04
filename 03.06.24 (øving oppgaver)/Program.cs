/*skriv et program som lar brukeren opprette og lagre informasjon om dyr. 
 * Programmet skal be brukeren om å skrive inn navn, art, 
 * og alder for et dyr og deretter lagre denne informasjonen. 
 * senere skal programmet kunne skrive ut informasjonen om dyrene i konsollen. 
 * brukeren skal da kunne velge "vis alle" eller "søk på art". 
 * søk skal ta vare på brukerens inpur og så vise de dyrene av arten brukeren etterspør. 
 * om ingen har denne artem skal dette også gis beskjed om i consollen.*/

//dyreprogram klasse
/*
 printInfo (all animals)
seachAnimal method


dyr klasse
navn
art
alder
 */

var theZoo = new ZooProgram();
theZoo.PrintAllInfo();
theZoo.LookForSpecies();