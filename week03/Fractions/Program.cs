using System;


class Program
{

        static void Main(string[] args)
        {
                string _fractionValue = "";
                double _decimalValue = 0;

                Fraction _fraction1 = new Fraction();
                _fractionValue = _fraction1.GetFractionString();
                Console.WriteLine(_fractionValue);
                
                _decimalValue = _fraction1.GetDecimalValue();
                Console.WriteLine(_decimalValue);
                Console.WriteLine();




                Fraction _fraction2 = new Fraction(5);

                _fractionValue = _fraction2.GetFractionString();
                Console.WriteLine(_fractionValue);

                _decimalValue = _fraction2.GetDecimalValue();
                Console.WriteLine(_decimalValue);
                Console.WriteLine();




                Fraction _fraction3 = new Fraction(3, 4);

                _fractionValue = _fraction3.GetFractionString();
                Console.WriteLine(_fractionValue);

                _decimalValue = _fraction3.GetDecimalValue();
                Console.WriteLine(_decimalValue);
                Console.WriteLine();




                Fraction _fraction4 = new Fraction(1, 3);

                _fractionValue = _fraction4.GetFractionString();
                Console.WriteLine(_fractionValue);

                _decimalValue = _fraction4.GetDecimalValue();
                Console.WriteLine(_decimalValue);
                Console.WriteLine();

        }
}



