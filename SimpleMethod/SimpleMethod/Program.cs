//Your application will prompt the user to enter a type of animal.  You will pass in the animal that the user typed into your method and then output the result.
//Create a method named Speak that accepts 1 parameter of type string and has a return type of string. The method will return the sound that the animal makes.
//Make this work for at least 3 animals (Dog, Monkey, Goat), if your method does not know about the animal that they asked about make up a sound.
//Call your method from the main method and output a message to the user
//There should be no console writeline or readline statements in your Speak method

string Speak(string animal)
{
    switch (animal)
    {
        case "Dog":
            return "Woof";
        case "Monkey":
            return "Ooh ooh aah aah";
        case "Goat":
            return "Bleat";
        default:
            return "Glorp";
    }
}

Console.WriteLine("Enter an animal: ");
string animal = Console.ReadLine();
Console.WriteLine(Speak(animal));

