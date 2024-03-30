using System;

class TimeConverter
{
    static void Main()
    {
        int seconds = 86400; // Example: 1 day in seconds

        double minutes = seconds / 60.0;
        double hours = minutes / 60.0;
            double days = hours / 24.0;
        double months = days / 30.0; // Approximation for simplicity

        Console.WriteLine($"{seconds} seconds is equal to:");
        Console.WriteLine($"{minutes} minutes:");
        Console.WriteLine($"{hours} hours:");
        Console.WriteLine($"{days} days:");
        Console.WriteLine($"{months} months:");

    }
}