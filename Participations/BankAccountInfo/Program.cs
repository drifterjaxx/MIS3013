//This program prompts the user for the number of bank accounts that they have.
//Validate that they entered a valid number, if they did not continue prompting them until they provide a valid number.
//Then prompt them for the balance of each bank account (you can validate these numbers once you are done with everything else). 
//Afterwards, output their total and their average balance.  If their average is greater than 5000, output the value in a different color of your choosing. 

Console.WriteLine("How many bank accounts do you have?");
string input = Console.ReadLine();
int numAccounts;

while (!int.TryParse(input, out numAccounts))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    input = Console.ReadLine();
}

double balance = 0;

for (int i = 1; i <= numAccounts; i++)
{
    Console.WriteLine($"Enter the balance of account {i}");
    balance += double.Parse(Console.ReadLine());
    if (i == numAccounts)
    {
        double average = balance / numAccounts;
       
        if (average > 5000)
        {
            Console.WriteLine("Your total balance is " + balance.ToString("C2"));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your average balance is " + average.ToString("C2"));
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Your total balance is " + balance.ToString("C2"));
            Console.WriteLine("Your average balance is " + average.ToString("C2"));
        }

    }
    
}


