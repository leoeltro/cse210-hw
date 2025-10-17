public class Swimming : Activity
{
   
    private int _laps; 

    // Constructor
    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        _laps = laps;
    }

   
    public override double GetDistanceKm()
    {
        // Each lap is 50 meters
        return ((double)_laps * 50) / 1000;
    }

    public override double GetSpeedKph()
    {
        double distance = GetDistanceKm();

        return (distance / DurationMinutes) * 60;
    }


    public override double GetPaceMinPerKm()
    {
        double distance = GetDistanceKm();
        return (double)DurationMinutes / distance;
    }
}