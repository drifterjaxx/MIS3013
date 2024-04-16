//Create a new C# console application and solution.  You will create two new classes, make sure you spell things correctly (case matters!).
//You will create the classes and then you will have the user enter all of the information for the ToyBoxes and all of the Toys inside of each ToyBox in your Program.cs Main method.
//Once the user is done inputting all of their Toys/ToyBoxes, output all the Toys for each ToyBox.  After you do that, output a random toy from each ToyBox.

using ToyClass;
using ToyBoxClass;

Console.WriteLine("Welcome to the Toy Box!");
Console.WriteLine("How many toyboxes are there?");
int numBoxes = int.Parse(Console.ReadLine());

for (int i = 0; i < numBoxes; i++)
{
    Toybox toybox = new Toybox();
}

for (int i = 0; i < numBoxes; i++)
{
    Console.WriteLine("What is the owner of the toybox?");
    string owner = Console.ReadLine();
    Console.WriteLine("What is the location of the toybox?");
    string location = Console.ReadLine();
    Toybox toybox = new Toybox();
    toybox.Owner = owner;
    toybox.Location = location;
    Console.WriteLine("How many toys are in the toybox?");
    int numToys = int.Parse(Console.ReadLine());
    for (int j = 0; j < numToys; j++)
    {
        Toy toy = new Toy();
        Console.WriteLine("What is the manufacturer of the toy?");
        toy.Manufacturer = Console.ReadLine();
        Console.WriteLine("What is the name of the toy?");
        toy.Name = Console.ReadLine();
        Console.WriteLine("What is the price of the toy?");
        toy.Price = double.Parse(Console.ReadLine());
        toybox.Toys.Add(toy);
    }
}






