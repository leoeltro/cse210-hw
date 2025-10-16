using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _duration = 0;
    private static string _textPrompt = "";
    private int _count;
    public List<string> _prompts = new List<string>();


    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _duration = duration;
    }




    public void Run()
    {
        GetRandomPrompt();
        Console.WriteLine();
        //Console.WriteLine("How much time do you need to read the prompt and also write down each answer you think of?");
        //int timeStep = int.Parse(Console.ReadLine())*1000;
        int timeStep = 6000;
        int elapsedTime = 0;

        Console.WriteLine($"  --->> The prompt is: {_textPrompt} You have 6 seconds to read it and think about your next answers to it! <<---");
        Thread.Sleep(timeStep);
        
        Console.WriteLine($"Now you will have the full {_duration} seconds to type responses to the prompt.");

        int timeIsUp = 0;
        DateTime startTime = DateTime.Now;
        while (timeIsUp == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Type an answer to the prompt:  ");
            string userResponse = Console.ReadLine();
            _prompts.Add(userResponse);

            DateTime futureTime = DateTime.Now;
            elapsedTime = (futureTime - startTime).Seconds;
            Console.WriteLine($"Elapsed time: {elapsedTime} seconds");
            if (elapsedTime >= _duration)
            {
                timeIsUp = 1;
                Console.WriteLine();     
                Console.WriteLine($"---> Time is up! The number of your listed items is: {_prompts.Count}");
            }




        }



    }



    public void GetRandomPrompt()
    {   
        int randomNumber = 0;
        Random random = new Random();
        randomNumber = random.Next(0, 5);
        switch (randomNumber)
        {
            case 0:
                _textPrompt =  "Who are people that you appreciate?";
                break;
            case 1:
                _textPrompt = "What are personal strengths of yours?";
                break;
            case 2:
                _textPrompt = "Who are people that you have helped this week?";
                break;
            case 3:
                _textPrompt = "When have you felt the Holy Ghost this month?";
                break;
            case 4:
                _textPrompt = "Who are some of your personal heroes?";
                break;
        }
        
    }




    public string GetListFromUser()
    {
        // TODO: Implement logic to get a list from the user
        return "";
    }
}