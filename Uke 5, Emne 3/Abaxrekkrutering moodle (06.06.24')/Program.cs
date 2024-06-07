

using Abaxrekkrutering_moodle__06._06._24__;

Veichle car1 = new Car("NF123456", "147kw", "200km/t", "green", "light"); //polymorphism
Veichle car2 = new Car("NF654321", "150kw", "195km/t", "blue", "light");

car1.PrintInfo();
car2.PrintInfo();
car1.CheckIfSame(car1);

car1.Run();


Veichle plane1 = new Plane("LN1234", "100kw", "30m", "2ton", "10ton", "jet plane");

plane1.PrintInfo();

plane1.Run();


Veichle boat1 = new Boat("ABC123", "100kw", "30knop", "500kg");

boat1.PrintInfo();
