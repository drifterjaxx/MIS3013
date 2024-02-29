//Create a list that will hold all of the users grades.  Keep prompting the user if they have another grade to enter until they say 'no'.
//Once you have all of the inputs, use a for each loop to iterate through the list and calculate the average.  Output the users grade average.

List<double> grades = new List<double>();
string input;
double grade;

while (true)
{
    Console.WriteLine("Do you have a grade to enter? (yes/no)");
    input = Console.ReadLine();
    if (input == "yes")
    {
        Console.WriteLine("Enter the grade: ");
        grade = Convert.ToDouble(Console.ReadLine());
        grades.Add(grade);
    }
    else if (input == "no")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
    }
}

double total = 0;
for (int i = 0; i < grades.Count; i++)
{
    total = total + grades[i];

}

double average = total / grades.Count;
Console.WriteLine("The average grade is " + average.ToString("0.00"));