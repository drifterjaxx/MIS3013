//This program reads in a .csv file. It calculates the total number of eggs from all bunnies, outputs all bunnies older than 75, and all bunnies younger than 20.
//When you output an Easter Bunny, make sure to show all of their information in a properly formatted sentence with how many Easter Baskets the Bunny needs.

using EasterBunny;

//Read in the .csv file to a list.
string[] lines = File.ReadAllLines("Easter_Bunny.csv");
List<Bunny> bunnies = new List<Bunny>();

for (int i = 1; i < lines.Length; i++)
{
    string[] parts = lines[i].Split(',');
    Bunny bunny = new Bunny();
    bunny.Name = parts[0];
    bunny.Age = int.Parse(parts[1]);
    bunny.DeliveryDate = parts[7];
    bunny.BasketSize = int.Parse(parts[6]);
    bunny.EggColor = parts[5];
    bunny.EggCount = int.Parse(parts[4]);
    bunny.Location = parts[3];
    bunny.FavoriteColor = parts[2];

    bunnies.Add(bunny);
}

//Calculate the total number of eggs from all bunnies.
int totalEggs = 0;
foreach (Bunny bunny in bunnies)
{
    totalEggs += bunny.EggCount;
}
Console.WriteLine("----------------");
Console.WriteLine($"Total Eggs: {totalEggs}");
Console.WriteLine("----------------");

//Output all bunnies older than 75.
Console.WriteLine("----------------");
Console.WriteLine("Bunnies older than 75");
Console.WriteLine("----------------");
foreach (Bunny bunny in bunnies)
{
    if (bunny.Age > 75)
    {
        Console.WriteLine($"{bunny.ToString()} needs {bunny.HowManyEasterBaskets()} Easter Baskets.");
    }
}

//Output all bunnies younger than 20.
Console.WriteLine("----------------");
Console.WriteLine("Bunnies younger than 20");
Console.WriteLine("----------------");
foreach (Bunny bunny in bunnies)
{
    if (bunny.Age < 20)
    {
        Console.WriteLine($"{bunny.ToString()} needs {bunny.HowManyEasterBaskets()} Easter Baskets.");
    }
}