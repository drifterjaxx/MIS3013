//Create parallel arrays, one will have the course subject (e.g. MIS, MATH, etc.) and the other will hold course numbers (e.g. 3033, 3013, etc.).
//Ask the user to input 3 for each, store them in the array.
//Then use a different loop to output the results to the user concatenated together (e.g. MIS3033, MATH3013).

string[] courses = new string[3];
int[] courseNumbers = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Please enter a course subject (e.g. MIS, MATH, etc.):");
    courses[i] = Console.ReadLine();
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Please enter a course number (e.g. 3033, 3013, etc.):");
    courseNumbers[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(courses[i] + courseNumbers[i]);
}