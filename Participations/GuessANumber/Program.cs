//Joseph Cartwright
//This program will generate a random number that the user will define the minimum value and the maximum value,
//using the Random class. Prompt the user to guess the random number until they successfully guess it.
//The program will validate whether the user entered a valid number and prompt the user to enter a valid number if they did not.

//Asking the user to enter the minimum and maximum values
Console.WriteLine("Enter the minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());

//Generating the random number
Random random = new Random();
int randomNumber = random.Next(min, max);

//Asking the user to guess the random number
Console.WriteLine("Guess the random number between " + min + " and " + max + ": ");
int guess = Convert.ToInt32(Console.ReadLine());

//Validating the user's guess using a while loop
while (guess != randomNumber)
{
    if (guess < min || guess > max)
    {
        Console.WriteLine("Invalid number. Please enter a number between " + min + " and " + max + ": ");
        guess = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Incorrect. Please try again: ");
        guess = Convert.ToInt32(Console.ReadLine());

    }
}

//If the user guesses the random number correctly
if (guess == randomNumber)
{
    Console.WriteLine("You guessed correctly!");
}
