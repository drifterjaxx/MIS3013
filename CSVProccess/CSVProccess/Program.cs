//Create a Console application that will read (File.ReadAllLines) in the sales_data_sample.csv .
//We want to sum up all of the sales with the status of Shipped and output the total sales by year (e.g. how much did we sell in 2003, 2004, 2005)
//as well as total sales by month across all years (e.g. how much did we sell in January of 2003/2004/2005 and February of 2003/2004/2005 etc.),
//make sure to output it as January/February etc and not 1/2.
//Output should consist of:
//Total for sales in 2003 - $
//Total for sales in 2004 - $
//Total for sales in 2005 - $
//Total for sales in the months of 'Next Month' (all years) - $


//Read all the lines from the file and store them in an array
string[] lines = File.ReadAllLines("sales_data_sample.csv");
double totalSales2003 = 0;
double totalSales2004 = 0;
double totalSales2005 = 0;
double totalSalesJanuary = 0;
double totalSalesFebruary = 0;
double totalSalesMarch = 0;
double totalSalesApril = 0;
double totalSalesMay = 0;
double totalSalesJune = 0;
double totalSalesJuly = 0;
double totalSalesAugust = 0;
double totalSalesSeptember = 0;
double totalSalesOctober = 0;
double totalSalesNovember = 0;
double totalSalesDecember = 0;

foreach (string line in lines.Skip(1))
{
    string[] column = line.Split(',');
    string status = column[6];
    string date = column[5];
    string[] dateSplit = date.Split('/');
    string month = dateSplit[0];
    string year = dateSplit[2];
    string sales = column[4];

    if (status == "Shipped")
    {
        if (year == "2003")
        {
            totalSales2003 += double.Parse(sales);
        }
        else if (year == "2004")
        {
            totalSales2004 += double.Parse(sales);
        }
        else if (year == "2005")
        {
            totalSales2005 += double.Parse(sales);
        }

        if (month == "1")
        {
            totalSalesJanuary += double.Parse(sales);
        }
        else if (month == "2")
        {
            totalSalesFebruary += double.Parse(sales);
        }
        else if (month == "3")
        {
            totalSalesMarch += double.Parse(sales);
        }
        else if (month == "4")
        {
            totalSalesApril += double.Parse(sales);
        }
        else if (month == "5")
        {
            totalSalesMay += double.Parse(sales);
        }
        else if (month == "6")
        {
            totalSalesJune += double.Parse(sales);
        }
        else if (month == "7")
        {
            totalSalesJuly += double.Parse(sales);
        }
        else if (month == "8")
        {
            totalSalesAugust += double.Parse(sales);
        }
        else if (month == "9")
        {
            totalSalesSeptember += double.Parse(sales);
        }
        else if (month == "10")
        {
            totalSalesOctober += double.Parse(sales);
        }
        else if (month == "11")
        {
            totalSalesNovember += double.Parse(sales);
        }
        else if (month == "12")
        {
            totalSalesDecember += double.Parse(sales);
        }
    }
}

Console.WriteLine("Total for sales in 2003 - $" + totalSales2003);
Console.WriteLine("Total for sales in 2004 - $" + totalSales2004);
Console.WriteLine("Total for sales in 2005 - $" + totalSales2005);
Console.WriteLine("Total for sales in the months of January (all years) - $" + totalSalesJanuary);
Console.WriteLine("Total for sales in the months of February (all years) - $" + totalSalesFebruary);
Console.WriteLine("Total for sales in the months of March (all years) - $" + totalSalesMarch);
Console.WriteLine("Total for sales in the months of April (all years) - $" + totalSalesApril);
Console.WriteLine("Total for sales in the months of May (all years) - $" + totalSalesMay);
Console.WriteLine("Total for sales in the months of June (all years) - $" + totalSalesJune);
Console.WriteLine("Total for sales in the months of July (all years) - $" + totalSalesJuly);
Console.WriteLine("Total for sales in the months of August (all years) - $" + totalSalesAugust);
Console.WriteLine("Total for sales in the months of September (all years) - $" + totalSalesSeptember);
Console.WriteLine("Total for sales in the months of October (all years) - $" + totalSalesOctober);
Console.WriteLine("Total for sales in the months of November (all years) - $" + totalSalesNovember);
Console.WriteLine("Total for sales in the months of December (all years) - $" + totalSalesDecember);