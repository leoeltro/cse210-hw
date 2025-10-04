


public class Word
{
    private string _text;
    private bool _isHidden = false;

    private static string[] _VersicleWords = [""];

    private int _numberWords = 0;
    private Random _random = new Random();
    private int _aleatoryNumber = 0;
    private int PositionToClearWord = 0;
    private string[] _wordToHide = [""];

    private int _numberWordsAlreadyHidden = 0;


    public  Word(string versicle)
    {
        _text = versicle;         
    }




    public void Hide()// Hide some words in the versicle
    {
        _VersicleWords = _text.Split(' ');
        _numberWords = _VersicleWords.Length;
        for (int i = 0; i <= _numberWords; i++)
        {
            _aleatoryNumber = _random.Next(0, _numberWords);
            if (_VersicleWords[_aleatoryNumber].Contains("-") == false)
            {
                PositionToClearWord = _aleatoryNumber;
            }
        }

        //Console.WriteLine();
        //Console.WriteLine(_text);

        _wordToHide[0] = _VersicleWords[PositionToClearWord];
        string hiddenWord = new string('-', _wordToHide[0].Length);// ***** Create a string with the same number of dashes as the word to hide

        _VersicleWords[PositionToClearWord] = hiddenWord;
        _text = string.Join(" ", _VersicleWords); // create the words to the string
        _numberWordsAlreadyHidden += 1;
        //Console.WriteLine(_numberWordsAlreadyHidden);
        //Console.WriteLine(_VersicleWords.Length);
        //Console.WriteLine();
        
    }



    public void Show() // Show the versicle with some words hidden
    {
            Console.WriteLine(_text);
            Console.WriteLine();
    }



    public bool IsHidden()
    {

        if (_numberWordsAlreadyHidden >= _numberWords && _numberWords > 0)
        {
            //Console.WriteLine(_numberWordsAlreadyHidden);
            //Console.WriteLine(_numberWords);

            _isHidden = true; // All words are hidden
            Console.WriteLine();
            Console.WriteLine("All words are hidden!");
            return _isHidden;
        }
        else
        {
            _isHidden = false;
            //Console.WriteLine("Not all words are hidden.");
            return _isHidden;
        }
        
    }



    public string GetDisplayText()
    {
        return _text;
    }
}
