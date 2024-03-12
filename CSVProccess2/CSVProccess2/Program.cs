//Create an application that will read in the following CSV file (SalesJan2009.csv).
//Add the file to your project so that it will copy it to your output directory.
//When the application loads, output all of the Names of the individual, as well as the Transaction_Date, who made the purchase.
//Only show the information about the individual (their name and the transation date) if they used a Visa AND the sale took place in the United States.

string[] lines = File.ReadAllLines("SalesJan2009.csv");
foreach (string line in lines)
{
    string[] splits = line.Split(',');
    //splits[0] = Transaction_date
    //splits[3] = Payment_Type
    //splits[4] = Name
    //splits[7] = Country

    string Transaction_date = splits[0];
    string Payment_Type = splits[3];
    string Name = splits[4];
    string Country = splits[7];

    if (Payment_Type == "Visa" && Country == "United States")
    {
        Console.WriteLine($"Name: {Name.PadRight(20)}| Transaction Date: {Transaction_date}");
    }
}