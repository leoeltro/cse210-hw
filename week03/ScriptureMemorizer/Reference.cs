
class Reference
{

   private string _book;

    private int _chapter;

    private int _verse;

    private int _endVerse;

    private string _versicle;


    private string John_3_16 = "For God so loved the world, that He gave His only Son, so that everyone who believes in Him will not perish, but have eternal life.";
    private string _Proverbs_3_5 = "Trust in the Lord with all your heart and lean not on your own understanding.";
    private string _Proverbs_3_5_6 = "[5] Trust in the Lord with all your heart lean not on your own understanding; [6] in all your ways submit to him, and he will make your paths straight.";




    public Reference(string book, int chapter, int verse)
    {
        if (book == "John" && chapter == 3 && verse == 16)
        {
            _versicle = John_3_16;
        }
        else if (book == "Proverbs" && chapter == 3 && verse == 5)
        {
            _versicle = _Proverbs_3_5;
        }

    }



    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;

        _chapter = chapter;

        _verse = verse;

        _endVerse = endVerse;


        if (_book == "Proverbs" && _chapter == 3 && _verse == 5 && _endVerse == 6)
        
            _versicle = _Proverbs_3_5_6;

    }


    public string GetDisplayText()
    {
        return _versicle;
    }

}