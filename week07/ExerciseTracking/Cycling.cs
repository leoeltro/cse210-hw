public class Cycling : Activity
{
    private double _speedKph; 
    

    public Cycling(DateTime date, int durationMinutes, double speedKph)
        : base(date, durationMinutes)
    {
        _speedKph = speedKph;
    }

    
    public override double GetDistanceKm()
    {
        return (_speedKph * DurationMinutes) / 60;
    }

  
    public override double GetSpeedKph()
    {
        return _speedKph;
    }

    public override double GetPaceMinPerKm()
    {        
        return 60 / _speedKph;
    }
}