

/*In this library management system:

LibraryItem is the base class with properties for the title, quantity, and base rental price of the item.
Book and Multimedia inherit from LibraryItem and add specific properties for books and multimedia items respectively.
IRentable is an interface with a method CalculateRentalPrice that is implemented in both derived classes to calculate the rental price, 
taking into account potential discounts or taxes.



You can create instances of Book and Multimedia, 
and call the CalculateRentalPrice method to see the calculated rental prices based on the defined logic.*/

using Library_Management_System__12._06._24_;

Book Book1 = new Book("Acotar", 2, 30.50, "Sarah J.Maas", "Fantasy");
Book Book2 = new Book("Me before you", 4, 34, "Jojo Moyes", "Fiction");

Console.WriteLine($"rental price after discount: {Book1.CalculateRentalPrice()}");
Console.WriteLine($"rental price after discount: {Book2.CalculateRentalPrice()}");


MultiMedia DVD1 = new MultiMedia("Cars", 7, 20.99, "DVD", 117);
MultiMedia AudioBook1 = new MultiMedia("Fairies", 3, 20.49, "Audio book", 70);

Console.WriteLine($"DVD rental price after tax: {DVD1.CalculateRentalPrice()}");
Console.WriteLine($"DVD rental price after tax: {DVD1.CalculateRentalPrice()}");

