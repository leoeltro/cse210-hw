using System;
using System.Threading;


public class BreathingActivity : Activity
{
    // ********** NOTA: PODERIA COLOCAR PUBLIC EM VEZ DE PRIVATE NA CLASSE ACTIVITY E NAO PRECISARIA DECLARAR AQUI
    // ESSAS VARIAVEIS REPETIDA E PODERIA USAR ELAS DIRETAMENTE   **********
    // private string _name = "";            
    // private string _description = "";
    private int _duration = 0;
    private int _numberOfRepetitions = 0;
    private int _intervalBetweenRepetitions = 0;

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        //_name = name;                     // SEM TER COLOCADO PUBLICA NAS VARIAVEIS DA CLASSE ACTIVITY PRECISA AGORA DECLARAR AS VARIAVEIS NOVAMENTE
        // _description = description;
        _duration = duration;
       
    }

    public void Run()
    {
        Console.WriteLine("Now enter the interval in seconds for each desired inhalation and exhalation:");
        int.TryParse(Console.ReadLine(), out _intervalBetweenRepetitions); // *****************    Convert string to int  *****************

        _numberOfRepetitions = (int)Math.Ceiling((double)_duration / (_intervalBetweenRepetitions * 1));
        Console.WriteLine("Duration will be: " + _numberOfRepetitions + " Intervals of inspiration and expiration of air!");
        for (int i = 0; i < _numberOfRepetitions; i++)
        {
            Console.WriteLine();
            Console.WriteLine("--- Now breathe in slowly ---");
            ShowSpinner(_intervalBetweenRepetitions/2);
            Console.WriteLine("--- Now breathe out slowly ---");
            ShowSpinner(_intervalBetweenRepetitions/2);
        }
        //DisplayEndingMessage();
        //Console.WriteLine();
    }
}







