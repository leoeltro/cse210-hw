// Author: Leonardo Barbosa Lima Gouvea
/*
1) The program begins by asking how long the activity will last. This option applies to all three existing types of activities (Breathing; Reflection; Listing).

2) After entering the text, a menu appears where you can enter 1, 2, or 3, depending on the type of activity listed.

3) If you entered 1 in the menu of available activity types, you will be taken to Breathing Activity.
3.1) The introductory messages are displayed, and you are asked how long each inhalation cycle will last. This time also applies to exhalation.
3.2) The inhalation and exhalation cycles then begin, with the entered time, and the spinning spinner is displayed. The total time for all cycles combined is the time entered at the beginning, as explained in item 1 of this explanatory text.

4) If you entered the number 2 in the available activities menu, you will be taken to Reflecting Activity.
4.1) You will be asked how long it will take to read each text containing each question to be presented as a guess for the prompt presented.
Here, you should enter a number less than the total time previously entered at the beginning of the program, referring to item 1 above. If you entered 30 seconds at the beginning and now enter 5 seconds in the second option, then 30/5 = 5 seconds per question or prompt message will be displayed. Thus, we have presented 1 prompt + 5 questions = 6 items of 5 seconds = 6 x 5 = 30 seconds. At the end, the number of questions displayed is displayed.

5) If you entered the number 3 in the available activities menu, you will be taken to Listing Activity. A random prompt is immediately displayed.
5.1) The time in seconds entered at the beginning of the program is the time you have to enter as many answers as you want, and at the end, the number of answers entered is displayed.
*/


using System;
using System.Threading;

class Program
{
    private static string _NameExercise = "";
    private static string _DescriptionText = "";
    private static int  _timeDuration = 0;
    private static int _choice = 0;

    static void Main(string[] args)
    {
        Console.Clear();
        //System("cls");
        Console.Write("Set the time in seconds that you want to do the activity:  ");
        int.TryParse(Console.ReadLine(), out _timeDuration);

        Console.WriteLine();
        Console.WriteLine(" Mindfulness Program Menu");
        Console.WriteLine("1- Start breathing activity");
        Console.WriteLine("2- Start reflecting activity");
        Console.WriteLine("3- Start listing activity");
        Console.WriteLine("Please choose an exercise option number 1 or 2 or 3: ");
        //int.TryParse(Console.ReadLine(), out _choice); // *****************    Convert string to int  *****************
        _choice = int.Parse(Console.ReadLine());
        

        if (_choice == 1)
        {
            _NameExercise = "Breathing Activity";
            _DescriptionText = "This activity will help you relax through breathing in and out slowly. Clear your mind and focus!";

            BreathingActivity _breathingActivity = new BreathingActivity(_NameExercise, _DescriptionText, _timeDuration);
            _breathingActivity.DisplayStartingMessage();
            _breathingActivity.Run();
            _breathingActivity.DisplayEndingMessage();
            Console.WriteLine();
        }


        else if (_choice == 2)
        {
            _NameExercise = "Reflection Activity";
            _DescriptionText = "This activity will help you reflect on times in your life, ands will help you recognize the power you have";

            ReflectingActivity _reflectingActivity = new ReflectingActivity(_NameExercise, _DescriptionText, _timeDuration);
            _reflectingActivity.DisplayStartingMessage();
            _reflectingActivity.Run(_timeDuration);
            _reflectingActivity.DisplayEndingMessage();
            Console.WriteLine();
        }


        else if (_choice == 3)
        {
            _NameExercise = "Listing Activity";
            _DescriptionText = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

            ListingActivity _listingActivity = new ListingActivity(_NameExercise, _DescriptionText, _timeDuration);
            _listingActivity.DisplayStartingMessage();
            _listingActivity.Run();
            _listingActivity.DisplayEndingMessage();
            Console.WriteLine();
        }


        else
        {
            Console.WriteLine("Invalid choice. Please select a valid option.");
        }

    }
}















/*

        Console.WriteLine("Hello World! This is the Homework Project.");
        Console.WriteLine();

        Console.WriteLine("------------------------------------------------------------");
        Assignment assignment01 = new Assignment("Leonardo", "History");
        _NameAndTopic = assignment01.GetSummary();
        Console.WriteLine(_NameAndTopic);
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();



        Console.WriteLine("------------------------------------------------------------");
        MathAssignment assignment02 = new MathAssignment("Gabriel", "Math", "5.1", "8-15");
        _NameAndTopic = assignment02.GetSummary();
        _sectiriteLine(_NameAndTopic);
        Console.WriteLine(_sectionAndProblem);
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();




        Console.WriteLine("------------------------------------------------------------");
        WritingAssignment assignment03 = new WritingAssignment("Leonardo", "History", "Lord of the Rings Mordor", "John Ronald Reuel Tolkien");
        _NameAndTopic = assignment03.GetSummary();
        _TitleAndAuthor = assignment03.GetWritingInformation();
        Console.WriteLine(_NameAndTopic);
        Console.WriteLine(_TitleAndAuthor);
        Console.WriteLine("------------------------------------------------------------");

onAndProblem = assignment02.GetHomeworkList();
        Console.W




    }
}

*/


