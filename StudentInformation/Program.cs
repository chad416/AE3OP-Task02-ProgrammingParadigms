// Student Information - Declarative Programming
// The program describes WHAT result we want (maximum, minimum, average),
// not HOW to calculate it. LINQ and its aggregation functions do the work,
// so there are no loops, counters or temporary variables for the calculations.

const int NumberOfGrades = 5;

Console.WriteLine("Student Information");
Console.WriteLine("===================");

List<double> grades = Enumerable.Range(1, NumberOfGrades)
    .Select(ReadGrade)
    .ToList();

double maximum = grades.Max();
double minimum = grades.Min();
double average = grades.Average();

Console.WriteLine();
Console.WriteLine($"Grades: {string.Join(", ", grades)}");
Console.WriteLine($"Maximum grade: {maximum}");
Console.WriteLine($"Minimum grade: {minimum}");
Console.WriteLine($"Average grade: {average:F2}");

// Asks for one grade and asks again until the input is a valid number.
double ReadGrade(int number)
{
    Console.Write($"Enter grade {number}: ");

    return double.TryParse(Console.ReadLine(), out double grade)
        ? grade
        : InvalidGrade(number);
}

double InvalidGrade(int number)
{
    Console.WriteLine("Invalid value. Please enter a numeric grade.");
    return ReadGrade(number);
}
