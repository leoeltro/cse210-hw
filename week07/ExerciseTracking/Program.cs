using System;

public class Program
{

    static int durationMinutes = 0; //
    static double distanceKm = 0.0;
    static int laps = 0;


    public static void Main()
    {

        durationMinutes = 30;   // Running
        distanceKm = 4.8;
        var running = new Running(new DateTime(2025, 10, 1), durationMinutes, distanceKm);


        durationMinutes = 30;   // Cycling
        distanceKm = 20.0;
        var cycling = new Cycling(new DateTime(2025, 10, 2), durationMinutes, distanceKm);


        durationMinutes = 30;   // Swimming
        laps = 6;
        var swimming = new Swimming(new DateTime(2025, 10, 3), durationMinutes, laps); // 40 laps * 50m = 2000m = 2.0 km


        List<Activity> activities = new List<Activity>
        {
            running,
            cycling,
            swimming,

        };

        Console.WriteLine("--- Activity Summaries ---");
        Console.WriteLine("Date | Type | Duration | Distance | Speed | Pace");
        Console.WriteLine("---------------------------------------------------------------------------------------");

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine("---------------------------------------------------------------------------------------");
    }
}