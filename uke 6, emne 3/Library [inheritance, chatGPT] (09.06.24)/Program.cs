/*
Create a Library class that holds a collection of LibraryItem objects.
Methods:
void RemoveItem(string title)
LibraryItem FindItem(string isbn)

Instructions:
Define the LibraryItem base class.
Create derived classes Book, Journal, and DVD.
Implement the Library class to manage LibraryItem objects.
Write a Main method to demonstrate the functionality:

Borrow and return items.
Find and remove items by ISBN.
Print details of each item.*/

using Library__inheritance__chatGPT___09._06._24_;

TheLibrary TheLibrary = new TheLibrary();


Book book1 = new Book("Acotar", "Sarah J.Maas", "HF787", false, 432, 398475, "05.24.24");
Book book2 = new Book("Harry Potter", "JK Rowling", "VH7487", false, 342, 7234, "12.11.10");

//book1.PrintDetails();

TheLibrary.AddItem(book1);
TheLibrary.AddItem(book2);


TheLibrary.AddItem(new Book("Another Book", "Bob", "89BV", false, 233, 748, "05.22.20"));
TheLibrary.AddItem(new Book("Yet Another Book", "Greg", "78GG", false, 333, 7777, "12.20.23"));
TheLibrary.AddItem(new Book("Books rule!", "Someone's librarian", "78GG", false, 832, 748, "11.21.20"));

TheLibrary.ItemsAvailable();
TheLibrary.FindItem("78GG");

//TheLibrary.ListAllItems();

//TheLibrary.RemoveItem("Another Book");

//TheLibrary.ListAllItems();







