//Create a new console application.  To start your application, call your DeveloperInformation method, passing in appropriate values (these are literal constants for YOU.  You do not need to ask the user for these values).
//Your application should prompt the user for  what type of calculation they want to perform and two values.
//You should use the appropriate function to perform the calculation and output the result IN YOUR MAIN CODE (NOT INSIDE THE FUNCTION). 
//Create the following methods:
//Add
//The add method should accept two parameters, both of type double, and should have a return type of double.
//The add method should add the first parameter by the second parameter (e.g. val1 + val2) and return the result
//Subtract
//The subtract method should accept two parameters, both of type double, and should have a return type of double.
//The subtract method should subtract the first parameter by the second parameter (e.g. val1 - val2) and return the result
//Multiply
//The multiply method should accept two parameters, both of type double, and should have a return type of double.
//The multiply method should multiply the first parameter by the second parameter (e.g. val1 * val2) and return the result
//Divide
//The divide method should accept two parameters, both of type double, and should have a return type of double.
//The divide method should divide the first parameter by the second parameter (e.g. val1 / val2) and return the result
//DeveloperInformation
//The DeveloperInformation method should accept three parameters, a string for the developers name, a string for the class name, and a string for the date of writing.  The method should have a return type of void..
//The DeveloperInformation method should use the three parameters to output a string on the console describing who wrote the application, for what class, and on what date
//EXTRA: Ask the user if they would like to perform a new calculation, or use the result of their previous calculation as the first value in a follow-up calculation, or if they will wish to stop. 

Console.WriteLine("What calculation do you want to perform?");
string calculation = Console.ReadLine();
Console.WriteLine("Enter the first value");
double val1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second value");
double val2 = Convert.ToDouble(Console.ReadLine());
double result = 0;

if (calculation == "add")
{
    result = Add(val1, val2);
}
else if (calculation == "subtract")
{
    result = Subtract(val1, val2);
}
else if (calculation == "multiply")
{
    result = Multiply(val1, val2);
}
else if (calculation == "divide")
{
    result = Divide(val1, val2);
}

Console.WriteLine($"The result of the calculation is {result}");

static double Add(double val1, double val2)
{
    return val1 + val2;
}

static double Subtract(double val1, double val2)
{
    return val1 - val2;
}

static double Multiply(double val1, double val2)
{
    return val1 * val2;
}

static double Divide(double val1, double val2)
{
    return val1 / val2;
}

DeveloperInformation("Joseph Cartwright", "MIS3013", "10/12/2021");

static void DeveloperInformation(string name, string className, string date)
{
    Console.WriteLine($"This application was written by {name} for the class {className} on {date}");
}

bool work = true;
do
{
    Console.WriteLine("Would you like to perform a new calculation, use the result of the previous calculation as the first value in a follow-up calculation, or stop?");
    string response = Console.ReadLine();

    if (response == "new")
    {
        Console.WriteLine("What calculation do you want to perform?");
        string calculation2 = Console.ReadLine();
        Console.WriteLine("Enter the first value");
        val1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second value");
        val2 = Convert.ToDouble(Console.ReadLine());
        result = 0;

        if (calculation2 == "add")
        {
            result = Add(val1, val2);
        }
        else if (calculation2 == "subtract")
        {
            result = Subtract(val1, val2);
        }
        else if (calculation2 == "multiply")
        {
            result = Multiply(val1, val2);
        }
        else if (calculation2 == "divide")
        {
            result = Divide(val1, val2);
        }

        Console.WriteLine($"The result of the calculation is {result}");
    }
    else if (response == "use")
    {
        Console.WriteLine("What calculation do you want to perform?");
        string calculation2 = Console.ReadLine();
        Console.WriteLine("Enter the second value");
        double val3 = Convert.ToDouble(Console.ReadLine());

        if (calculation2 == "add")
        {
            result = Add(result, val3);
        }
        else if (calculation2 == "subtract")
        {
            result = Subtract(result, val3);
        }
        else if (calculation2 == "multiply")
        {
            result = Multiply(result, val3);
        }
        else if (calculation2 == "divide")
        {
            result = Divide(result, val3);
        }

        Console.WriteLine($"The result of the calculation is {result}");
    }
    else if (response == "stop")
    {
        Console.WriteLine("Goodbye!");
        work = false;
        return;
    }
    else
    {
        Console.WriteLine("Invalid response");
    }
}
while (work = true);