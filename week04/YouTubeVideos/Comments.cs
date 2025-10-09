using System;

public class Comments
{
    public string _namePersonCommented;
    public string _textCommentary;

    public Comments(string namePersonCommented, string commentaryText)
    {
        _namePersonCommented = namePersonCommented;
        _textCommentary = commentaryText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Name: {_namePersonCommented};    Comment: {_textCommentary}");
        //Console.WriteLine();
    }

}
