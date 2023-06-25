using System;

class Program
{
    static void Main(string[] args)
    {
        int seconds = 332;
        string formattedTime = FormatTime(seconds);
        Console.WriteLine(formattedTime);
    }

    static string FormatTime(int seconds)
    {
        int hours = seconds / 3600;
        int minutes = (seconds % 3600) / 60;
        int remainingSeconds = seconds % 60;

        string formattedHours = hours.ToString("D2");
        string formattedMinutes = minutes.ToString("D2");
        string formattedSeconds = remainingSeconds.ToString("D2");

        return $"{formattedHours}:{formattedMinutes}:{formattedSeconds}";
    }
}
