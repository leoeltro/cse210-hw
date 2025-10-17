using System;
using System.Collections.Generic;

public abstract class Activity
{

    private DateTime _date;
    private int _durationMinutes; 
    // Constructor
    public Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }


   public int DurationMinutes => _durationMinutes;

 
    public abstract double GetDistanceKm();
    public abstract double GetSpeedKph();
    public abstract double GetPaceMinPerKm();

    public virtual string GetSummary()
    {
       
        return $"{_date.ToShortDateString()} {this.GetType().Name} ({_durationMinutes} min) - " +
               $"Distance {GetDistanceKm():F2} km, " +
               $"Speed {GetSpeedKph():F2} kph, " +
               $"Pace {GetPaceMinPerKm():F2} min/km";
    }
}