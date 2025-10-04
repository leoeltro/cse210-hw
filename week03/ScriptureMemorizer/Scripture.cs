using System;
using System.Linq;



public class Scripture
{
    private string referenceHiddenText = "";
    private static List<string> _words = new List<string>();



    int _count = 1;
    public List<Word> ScriptureMethod(bool ReferenceToFinal, string text)
    {
        referenceHiddenText = text;
        bool _finalSignal = ReferenceToFinal;


        if (_words == null)
            {
                _words = new List<string>();
            }
        _words.Add(_count.ToString());
        _count += 1; 

        _words.Add(referenceHiddenText);// 


        if (_finalSignal == true) // Test if all words are hidden
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("The final collection of words redicted are: ");
                Console.WriteLine(string.Join(" <> ", _words));
            }
            

        // Convert the words to List<Word> and return
            List<Word> wordList = new List<Word>();
        foreach (var w in _words)
        {
            wordList.Add(new Word(w));
        }
        return wordList;
    }





    public void HideRandomWords(int numberToHide)
    {

    }





    public string GetDisplayText()
    {
        return "";
    }





    public bool IsCompletelyHidden()
    {
        return true;  // true or false
    }
}



