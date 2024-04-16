//We want to read in a data set of Cereal information and help answer a few questions for the user.
//The application should output all of the Cereal information that have a serving size that is 1 cup or more.
//After you output all those cereals, we also need to inform them which Cereals have 100 calories or less per serving.

using Cereals;

//New Cereal object
List<Cereal> cerealList = new List<Cereal>();

//Read in the .txt file
string[] lines = System.IO.File.ReadAllLines("Cereal_Data.txt");
for (int i = 1; i < lines.Length; i++)
{
    Cereal c = new Cereal();
    string[] cerealInfo = lines[i].Split('|');
    c.Manufacturer = cerealInfo[0];
    c.Name = cerealInfo[1];
    c.Calories = Convert.ToDouble(cerealInfo[2]);
    c.Cups = Convert.ToDouble(cerealInfo[3]);
    cerealList.Add(c);
}

//Cereals with a serving size of 1 cup or more
Console.WriteLine("Cereals with a serving size of 1 cup or more:");
Console.WriteLine("---------------------------------------------");
foreach (Cereal cereal in cerealList)
{
    if (cereal.Cups >= 1)
    {
        Console.WriteLine("Manufacturer: " + cereal.Manufacturer);
    }
}


//Cereals with 100 calories or less per serving
Console.WriteLine("Cereals with 100 calories or less per serving:");
Console.WriteLine("---------------------------------------------");
foreach (Cereal cereal in cerealList)
{
    if (cereal.Calories <= 100)
    {
        Console.WriteLine("Manufacturer: " + cereal.Manufacturer);
    }
}
