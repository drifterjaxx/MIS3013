//This program allows the user to enter a number they want to count to, and the interval at which they want to count.
//The program will then count to the number the user entered, at the interval the user entered, and display the numbers as it counts.
//The program will start counting at the interval the user entered.

Console.WriteLine("Enter a number to count to: ");
int countTo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter an interval to count by: ");
int interval = Convert.ToInt32(Console.ReadLine());

for (int i = interval; i <= countTo; i += interval)
{
    Console.WriteLine(i);
}
