
using System;
using System.Threading;

public class Activity
{
    private string _name = "";
    private string _description = "";
    private int _duration = 0;


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }


    public void DisplayStartingMessage()
    {
        //Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Welcome to the { _name }.");
        Console.WriteLine("Description: " + _description); // FORMA 2 DE  IMPRIMIR INFORMAÇOES
        Console.WriteLine("The time duration of the activity will be: " + _duration + " seconds");
        Console.WriteLine();

    }


    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("You have completed the exercise, congratulations.");
    }




    public void ShowSpinner(int seconds)
    {
        int elapsedSeconds = 0;
        int spaceTime = 200;

        while (elapsedSeconds < (seconds * 1000))
        {
            for (int i = 0; i < 4; i++)
            {
                if (elapsedSeconds >= (seconds * 1000))
                {
                    break;
                }

                if (i == 0)
                {
                    Console.Write("|");
                    Thread.Sleep(spaceTime);
                    elapsedSeconds += spaceTime;
                    Console.Write("\b \b");
                }

                else if (i == 1)
                {
                    Console.Write("/");
                    Thread.Sleep(spaceTime);
                    elapsedSeconds += spaceTime;
                    Console.Write("\b \b");
                }

                else if (i == 2)
                {
                    Console.Write("--");
                    Thread.Sleep(spaceTime);
                    elapsedSeconds += spaceTime;
                    Console.Write("\b \b");
                }

                else if (i == 3)
                {
                    Console.Write("\\");
                    Thread.Sleep(spaceTime);
                    elapsedSeconds += spaceTime;
                    Console.Write("\b \b");
                }
                Console.Write("\b\b\b");

            }
        }

    }




    public void ShowCountDown(int seconds)
    {
        Thread.Sleep(seconds);
        Console.WriteLine("I'm back!!");
    }
}


