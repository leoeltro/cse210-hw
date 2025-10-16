using System;
using System.Threading;



public class ReflectingActivity : Activity
{
    private  string _name = "";
    private string _description = "";
    private int _duration = 0;
    private string _textPrompt = "";

    private string _textQuestion = "";


    private List<string> _prompts = new List<string>();

    private List<string> _questions = new List<string>();


    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;                     // SEM TER COLOCADO PUBLICA NAS VARIAVEIS DA CLASSE ACTIVITY PRECISA AGORA DECLARAR AS VARIAVEIS NOVAMENTE
        _description = description;
        _duration = duration;

    }



    public void Run(int duration)
    {
        int elapsedTime = 0;
        int timeStep = 3000;

            Console.WriteLine("How long in seconds do you want to spend thinking about each question?  ");
            int secondsPerQuestion;
            if (int.TryParse(Console.ReadLine(), out secondsPerQuestion))
            {
                timeStep = secondsPerQuestion * 1000;
            }
            else
            {
                Console.WriteLine("Invalid input. Using default of 3 seconds per prompt and question.");
                timeStep = 3000;
            }
        _textPrompt = GetRandomPrompt();
            _prompts.Add(_textPrompt);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($" --->> The situation to be considered is: {_textPrompt} <<---");
            Console.WriteLine();
            elapsedTime += timeStep;
            Thread.Sleep(timeStep);
            while (elapsedTime < (duration * 1000))
            {
            _textQuestion = GetRamdomQuestion();
                _questions.Add(_textQuestion);
                Console.WriteLine($"The question to be considered is: {_textQuestion}");
                
                elapsedTime += timeStep;
                ShowSpinner(timeStep/1000);
                //Thread.Sleep(timeStep);
            }
        Console.WriteLine($"---> The number of showed questions is: {_questions.Count}");
            Console.WriteLine($"---> The number of showed prompts is: {_prompts.Count}");
            //DisplayEndingMessage();
            //Console.WriteLine();
    }



    public string GetRandomPrompt()
    {
        string textPrompt = "";
        int randomNumber = 0;
        Random random = new Random();
        randomNumber = random.Next(0, 4);
        switch (randomNumber)
        {
            case 0:
                textPrompt = "Think of a time when you stood up for someone else.";
                break;
            case 1:
                textPrompt = "Think of a time when you did something really difficult.";
                break;
            case 2:
                textPrompt = "Think of a time when you helped someone in need.";
                break;
            case 3:
                textPrompt = "Think of a time when you did something truly selfless.";
                break;
        }
        return textPrompt;
    }



    public string GetRamdomQuestion()
    {
        _textQuestion = "";
        int randomNumber = 0;
        Random random = new Random();
        randomNumber = random.Next(0, 9);
        switch (randomNumber)
        {
            case 0:
                _textQuestion = "Why was this experience meaningful to you?";
                break;
            case 1:
                _textQuestion = "Have you ever done anything like this before?";
                break;
            case 2:
                _textQuestion = "How did you get started?";
                break;
            case 3:
                _textQuestion = "How did you feel when it was complete?";
                break;
            case 4:
                _textQuestion = "What made this time different than other times when you were not as successful?";
                break;
            case 5:
                _textQuestion = "What is your favorite thing about this experience?";
                break;
            case 6:
                _textQuestion = "What could you learn from this experience that applies to other situations?";
                break;
            case 7:
                _textQuestion = "What did you learn about yourself through this experience?";
                break;
            case 8:
                _textQuestion = "How can you keep this experience in mind in the future?";
                break;
        }

        return _textQuestion;
    }



    public void DisplayPrompt()
    {
        Console.WriteLine(_textQuestion);

    }



    public void DisplayQuestions()
    {

    }
}