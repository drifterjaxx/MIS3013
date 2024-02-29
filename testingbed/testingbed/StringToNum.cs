//Prompt the user to enter two numbers. The user will input 0 – 9 as a word (e.g. Zero, One, Two, Three, Four, Five, Six, Seven, Eight, or Nine).
//Convert these two numbers from a word format to a numeric format and add them together.  Output the result to the user with 1 decimal place.

Console.WriteLine("Enter the first number as a word: ");
string firstNumber = Console.ReadLine();
Console.WriteLine("Enter the second number as a word: ");
string secondNumber = Console.ReadLine();

static int ConvertToNumber(string number)
{
    switch (number.ToLower())
    {
        case "zero":
            return 0;
        case "one":
            return 1;
        case "two":
            return 2;
        case "three":
            return 3;
        case "four":
            return 4;
        case "five":
            return 5;
        case "six":
            return 6;
        case "seven":
            return 7;
        case "eight":
            return 8;
        case "nine":
            return 9;
        default:
            return -1;
    }
}

int first = ConvertToNumber(firstNumber);
int second = ConvertToNumber(secondNumber);

if (first == -1 || second == -1)
{
    Console.WriteLine("Invalid input");
}
else 
{
    int answer = first + second;
    Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " + answer.ToString("0.0") + "!");
}

