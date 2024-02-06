//CoinFlip Game, choosing between 0 or 1 to represent heads or tails using the Random class

//Create a new instance of the Random class
//Create a new variable to store the result of the flip
Random flip = new Random();
int coin = flip.Next(0, 1 + 1);


//0 represents heads, 1 represents tails
Console.WriteLine("Choose heads or tails.");
string choice = Console.ReadLine();

if (choice == "heads" && coin == 0)
{
    Console.WriteLine("You chose correctly!");
}
else if (choice == "tails" && coin == 1)
{
    Console.WriteLine("You chose correctly!");
}
else
{
    Console.WriteLine("You chose incorrectly.");
}

if (coin == 0)
{
    Console.WriteLine("The coin landed on heads.");
}
else
{
    Console.WriteLine("The coin landed on tails.");
}

const string dev = "Joseph Cartwright";
Console.WriteLine("Developed by " + dev);
