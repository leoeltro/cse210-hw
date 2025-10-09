using System;

public class Video
{
    string _title;
    string _author;
    string _durationVideo;
    int numberComments;
    public Video(string title, string author, string durationVideo)
    {
        _title = title;
        _author = author;
        _durationVideo = durationVideo;
    }


    public void DisplayVideoInformation()
    {
        Console.WriteLine("Video informations: ");
        Console.WriteLine($"Title of Video: {_title};   Author: {_author};   Duration: {_durationVideo}");
        Console.WriteLine();
    }

    public List<Comments> _comments = new List<Comments>(); // List to store comments

    public int ShowComments()
    {
        
        Console.WriteLine("Set Of Comments: ");
        foreach (Comments comentary in _comments)
        {
            // Specify the correct DisplayComment method if there are overloads, or remove duplicates in Comments class
            comentary.DisplayComment();
            numberComments = _comments.Count;
        }
        return numberComments;
    }
}
