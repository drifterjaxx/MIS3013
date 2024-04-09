//Create a new C# console application and solution.  You will create one new class, make sure you spell things correctly (case matters!).
//You will create the class and then you will create 2 instances, or objects, of each class in your Program.cs Main method and display all the information to the user about each of your Toys
//The UML's for the classes are below:
//Toy
//+Manufacturer : string
//+Name : string
//+Price : double
//-Notes : string
//+Toy( )
//+GetAisle( ) : string
//GetAisle() - Returns the first letter of the Manufacturer, capitalized with a random number between 1 and 24 appended to the end of the letter. 
//Come up with a way in which you can set the value for Notes on each Toy and a way you could get the value for the Toy and display it in the Main method
//Extra: Create a collection to hold all of your toys!

using ToyClass;

Toy amogus = new Toy();
Toy john_fortnite = new Toy();

amogus.Manufacturer = "Hasbro";
john_fortnite.Manufacturer = "Epic Games";

Console.WriteLine(amogus.GetAisle());
amogus.AddNotes();
Console.WriteLine(amogus.GetNotes());

Console.WriteLine(john_fortnite.GetAisle());
john_fortnite.AddNotes();
Console.WriteLine(john_fortnite.GetNotes());


