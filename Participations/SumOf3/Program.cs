// Joseph Cartwright//
// Date: 1/30/2018//
// This program will ask the user to enter 3 numbers and then display the sum of the 3 numbers.//

const double magicValue = 7.777;

Console.Write("Enter the first number: ");
string firstNum = Console.ReadLine();
double num1 = Convert.ToDouble(firstNum);

Console.Write("Enter the second number: ");
string secondNum = Console.ReadLine();
double num2 = Convert.ToDouble(secondNum);

Console.Write("Enter the third number: ");
string thirdNum = Console.ReadLine();
double num3 = Convert.ToDouble(thirdNum);

double sum = num1 + num2 + num3;
Console.WriteLine("The sum of the three numbers is: " + sum);
Console.WriteLine("The sum times the magic value is: " + sum * magicValue);
