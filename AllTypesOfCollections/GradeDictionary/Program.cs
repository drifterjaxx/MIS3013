//Create a dictionary that will hold multiple values.
//The key will be the course code (e.g. MIS3013, MIS3383, etc.) and the values will be all of the students final grades (e.g. 0.95, 0.8, etc.).
//Add at least 3 courses codes and at least 3 grades in each one.
//Calculate the average for each course code and output it to the user, make sure to format it as a percent.
//If you have time, convert #3 to getting input from the user and making sure the key doesn't exist prior to adding it

Dictionary <string, List<double>> gradeDictionary = new Dictionary<string, List<double>>();

gradeDictionary.Add("MIS3013", new List<double>());
gradeDictionary["MIS3013"].Add(0.9751);
gradeDictionary["MIS3013"].Add(0.8863);
gradeDictionary["MIS3013"].Add(0.6942);
gradeDictionary.Add("MIS3383", new List<double>());
gradeDictionary["MIS3383"].Add(0.9991);
gradeDictionary["MIS3383"].Add(0.7889);
gradeDictionary["MIS3383"].Add(0.9142);
gradeDictionary.Add("MIS4340", new List<double>());
gradeDictionary["MIS4340"].Add(0.6568);
gradeDictionary["MIS4340"].Add(0.4269);
gradeDictionary["MIS4340"].Add(0.9987);

for (int i = 0; i < gradeDictionary.Count; i++)
{
    string courseCode = gradeDictionary.ElementAt(i).Key;
    List<double> grades = gradeDictionary[courseCode];
    double total = 0;
    for (int j = 0; j < grades.Count; j++)
    {
        total += grades[j];
    }
    double average = total / grades.Count;
    Console.WriteLine($"The average for {courseCode} is {average.ToString("P")}");
}
