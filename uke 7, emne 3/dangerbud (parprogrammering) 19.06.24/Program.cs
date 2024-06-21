/*

    
 DangerBug
   Denne appen skal brukes som starten på et oppslagsverk på om et insekt er giftig eller kan gi plager på andre måter eller ikke.
   Lag en baseklasse som heter “bug” og la de andre insektsypene arve hovedegenskapene til insekter fra denne (kan bite, har bein, kan bevege seg f.eks:) )
   Lag klasser for mygg med dens unike egenskaper (kan fly, suger blod, gir følgende plage: kløe)
   Husflue (kan fly,plage:  kan spre sykdommer)
   Edderkopp (goodstuff:spiser fluer og midd, plage: kan bite mennesker)
   Flått (plage: kan gi alvorlig sykdom)
   Veps(kan fly, plage: giftig, kan gi alvorlig sykdom/død ved allergi)
   Gjør det mulig å legge inn flere insekter med konsollen.
   Start options i konsollen skal være 
   Se liste over insekter  -- her skal alle insektene listes opp, og man skal kunne velge ett og gå inn å så på egenskapene dens (om den er farlig, plagende eller annet)
   Legge inn flere insekter

 */

using dangerbud__parprogrammering__19._06._24;

MyBugs myBugs = new MyBugs();

myBugs.AddBugsToList();


var mosqito = new Mosqito();
var wasp = new Wasp();
var tick = new Tick();
var spider = new Spider();
var fly = new Fly();

myBugs.AddBugsToList(mosqito);