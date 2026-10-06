using System;

class Program
{
    static void Main()
    {
        // Birthdate
        DateTime birthDate = new DateTime(2003, 5, 15);

        // Current date and time
        DateTime currentDate = DateTime.Now;

        // Calculate the difference
        TimeSpan difference = currentDate - birthDate;

        // Calculate age
        int age = currentDate.Year - birthDate.Year;

        if (currentDate < birthDate.AddYears(age))
        {
            age--;
        }

        Console.WriteLine($"Birthdate: {birthDate:yyyy-MM-dd}");
        Console.WriteLine($"Current date: {currentDate}");
        Console.WriteLine($"Age: {age} years");

        // Add 10 days to birthdate
        DateTime dateAfter10Days = birthDate.AddDays(10);

        Console.WriteLine($"Birthdate after 10 days: {dateAfter10Days:yyyy-MM-dd}");
    }
}