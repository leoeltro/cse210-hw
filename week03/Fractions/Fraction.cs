using System;


public class Fraction
{

    private int _top;
    private int _bottom;  

    private string _fraction; // fraction string
    private double _decimal; // decimal value

    private string _fraction_1;
    private double _decimal_1;
    private string _fraction_2;
    private double _decimal_2;
    private string _fraction_3;
    private double _decimal_3;


    private int function_selection; // 1 = default, 2 = whole number, 3 = numerator/denominator

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        _fraction_1 = $"{_top}/{_bottom}";
        _decimal_1 = (double)_top / (double)_bottom;
        function_selection = 1;
    }


    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
        _fraction_2 = $"{_top}/{_bottom}";
        _decimal_2 = (double)_top / (double)_bottom;
        function_selection = 2;
    }


    public Fraction(int top, int bottom)
    {
        int _top = top;
        int _bottom = bottom;
        _fraction_3 = $"{_top}/{_bottom}";
        _decimal_3 = (double)_top / (double)_bottom;
        function_selection = 3;
    }


    public string GetFractionString()
    {
        if (function_selection == 1)
            {
                _fraction = _fraction_1;
            }
        else if (function_selection == 2)
            {
                _fraction = _fraction_2;
            }
        else if (function_selection == 3)
            {
                _fraction = _fraction_3;
            }
        else
            {
                _fraction = "Error";
            }

        return _fraction;
    }


    public double GetDecimalValue()
    {
        if(function_selection == 1)
            {
                _decimal = _decimal_1;
            }
        else if (function_selection == 2)
            {
                _decimal = _decimal_2;
            }
        else if (function_selection == 3)
            {
                _decimal = _decimal_3;
            }
        else
            {
                _decimal = 0;
            }
        return _decimal;
    }
    




}