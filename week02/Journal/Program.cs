
// W02 Project: Journal Program

// Author: Leonardo Barbosa Lima Gouvea
/*
The program performs the following tasks:

1) Typing 1 provides the date and a random prompt (there are 5 in total), and the user must enter an answer.

After typing the answer, the user is asked if they want to continue, and the main menu is displayed again. With each iteration, typing y continues the program, but typing n stops the prompt and exits the program.

If you are in the main menu and type option 5, you also exit the program.

2) Option 2 of the menu displays each line that was typed here from the time the program was opened and the user entered input to the prompt.
It is displayed line by line. Press any key to continue displaying new lines and press the ESC key to stop displaying.

3) Option 3 loads a file that you previously saved. You must enter the file name myFile.txt because my program only saves this file name, and the file save menu still needs improvement. When you type myFile.txt, the file is loaded and everything previously typed is printed to the screen at once.

4) Menu number 4 started but wasn't finished. So the program automatically saves a file, myFile.txt, always adding more data to it.

5) Option 5 exits the program.

I had difficulty implementing global variables and placing functions within others and forming classes. I was getting an error when defining a class.

*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Net;
//public static string global_text;

public class Program
{
    static void Main(string[] args)
    {
        //Console.Clear();
        PromptGenerator _promptNow = new PromptGenerator();
        string response;
        

        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Please select one to about Your diary: ");
            string choice = Console.ReadLine();
            int numberChoice = int.Parse(choice);
            Console.WriteLine();
            //Console.WriteLine($"You selected: {numberChoice}.");



            switch (numberChoice)
            {
                case 1:
                    //Console.Write("Date: ");
                    //DateTime theCurrentTime = DateTime.Now;
                    //string dateText = theCurrentTime.ToShortDateString();
                    //Console.WriteLine(dateText);
                    //var _date = DateTime.Now;
                    //Console.WriteLine(_date);

                    string response2;
                    response2 = PromptGenerator.GetRandomPrompt(); //Console.WriteLine();
                    //response2= _promptNow.GetRandomPrompt(); //Console.WriteLine();
                    //Console.WriteLine();
                    //Console.Write("Type about your personal responde: ");
                    //string _promptText = Console.ReadLine();
                    break;


                case 2:
                    Console.WriteLine($"All prompts and answers will now be shown: ");
                    Console.WriteLine();
                    string filename2 = "myFile.txt";
                    List<string> lines = new List<string>();
                    if (File.Exists(filename2))
                    {
                        lines.AddRange(File.ReadAllLines(filename2));
                    }
                    for (int i = 0; i < lines.Count; i++) // Display all prompts in the list
                    {
                        Console.Write("press any key to continue and ESC to exit: ");
                        Console.WriteLine(lines[i]);

                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                        {
                            break;
                        }

                    }
                    // Display
                    break;


                case 3:
                    Console.Write("Enter the name of the txt file to be uploaded for example xxxxxxx.txt: ");
                    string choice3 = Console.ReadLine();
                    string filename3 = choice3;

                    List<string> lines3 = new List<string>();
                    if (File.Exists(filename3))
                    {
                        lines3.AddRange(File.ReadAllLines(filename3));
                    }
                    Console.WriteLine($"The file {choice3} was loaded: ");


                    Console.WriteLine($"The contents of the file {choice3} will be displayed : ");

                    for (int i = 0; i < lines3.Count; i++) // Display all prompts in the list
                    {
                        Console.WriteLine(lines3[i]);
                    }
                    // Save
                    break;

                    // Display
                    break;
                // Load



                case 4:
                    Console.Write("Enter the name of the txt file to be uploaded for example xxxxxxx.txt: ");
                    string choice4 = Console.ReadLine();

                    //global_text += _texts_collection;        
                    string filename = choice4;
                    using (StreamWriter outputFile = new StreamWriter(filename))
                       // outputFile.WriteLine(global_text);



                    // Save
                    break;


                case 5:
                    Environment.Exit(0);
                    // Quit
                    break;
                default:
                    break;
            }
            Console.WriteLine();
            Console.Write("Type y to continue or n to end? y or n:  ");
            response = Console.ReadLine();
        } while (response == "y");
    }


}




//______________________________________________________________________________________

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public void Display()  // function to display job information
    {


    }
}




//______________________________________________________________________________________

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {

    }


    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }
}




//______________________________________________________________________________________
public class PromptGenerator
{
    
    public static List<string> _prompts;// = new List<string>();

    public static string GetRandomPrompt()
    {
        if (_prompts == null)
        {
            _prompts = new List<string>();
        }

        Console.Write("Date: "); //  date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine(dateText);

        Random random = new Random();// Create a Random object
        int randomNumber = random.Next(1, 6);
        string phrase = "";
        switch (randomNumber)
        {
            case 1:
                phrase = "Who was the most interesting person I interacted with today?";
                break;
            case 2:
                phrase = "What was the best part of my day?";
                break;
            case 3:
                phrase = "How did I see the hand of the Lord in my life today?";
                break;
            case 4:
                phrase = "What was the strongest emotion I felt today?";
                break;
            case 5:
                phrase = "If I had one thing I could do over today, what would it be?";
                break;
            default:
                break;
        }
        Console.WriteLine($"The prompt for now is: {phrase}");  

        Console.Write("Type about your personal responde: ");// Prompt user to type the text
        string _promptText = Console.ReadLine();
        Console.WriteLine(); Console.WriteLine();


        _prompts.Add(dateText);// Add the date to the list
        _prompts.Add(phrase); // Add the above aleatory prompt to the list
        _prompts.Add(_promptText);// Add the user text to the list
        _prompts.Add("/");// end marker used


        string _texts_collection = "";
        for (int i = 0; i < _prompts.Count; i++) // Display all prompts in the list
        {
            Console.WriteLine(_prompts[i]);
            _texts_collection += _prompts[i] + Environment.NewLine;
        }

        
        global_text += _texts_collection;
        
        string filename = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        outputFile.WriteLine(_texts_collection);

        return _texts_collection;// Return the selected prompt

    }

    public static string global_text = "";
}



