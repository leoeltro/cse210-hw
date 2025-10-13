using System;

class Program
{
    private static string _NameAndTopic = "";
    private static string _sectionAndProblem = "";
    private static string _TitleAndAuthor = "";
    static void Main(string[] args)
    {
        Console.Clear();
        //System("cls");
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
        _sectionAndProblem = assignment02.GetHomeworkList();
        Console.WriteLine(_NameAndTopic);
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






    }
}