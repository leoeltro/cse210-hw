public class Running : Activity
{
   
    private double _distanceKm; 

    // Constructor
    public Running(DateTime date, int durationMinutes, double distanceKm)
        : base(date, durationMinutes)
    {
        _distanceKm = distanceKm;
    }

    
    public override double GetDistanceKm()
    {
        return _distanceKm;
    }

    public override double GetSpeedKph()
    {
       
        if (DurationMinutes == 0) return 0;
        return (_distanceKm / DurationMinutes) * 60;
    }

    public override double GetPaceMinPerKm()
    {
        return (double)DurationMinutes / _distanceKm;
    }
}