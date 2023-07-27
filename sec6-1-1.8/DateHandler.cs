using System;

public class DateHandler
{
    public void doApp()
    {
        // Get the current date and time
        DateTime currentDate = DateTime.Now;

        // Display the current date and time
        Console.WriteLine("Current Date and Time: " + currentDate);

        // Display only the current date (without time)
        Console.WriteLine("Current Date: " + currentDate.Date);

        // Get the current year, month, and day separately
        int year = currentDate.Year;
        int month = currentDate.Month;
        int day = currentDate.Day;

        // Display the date components separately
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Month: " + month);
        Console.WriteLine("Day: " + day);

        // Create a custom date
        DateTime customDate = new DateTime(2023, 7, 26);

        // Display the custom date
        Console.WriteLine("Custom Date: " + customDate);

        // Perform date arithmetic
        DateTime futureDate = customDate.AddDays(30);
        Console.WriteLine("Custom Date + 30 days: " + futureDate);
    }
}
