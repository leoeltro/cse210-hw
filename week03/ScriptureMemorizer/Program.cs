
using System;

/*
AUTHOR: Leonardo Barbosa Lima Gouvea

The program contains three classes in addition to the Program.cs code in another file.

The registered books are:
John       3   16
Proverbs   3   5
Proverbs   3   5   6

1) Type John or Proverbs: To use the program, you must first enter the BOOK number. There are only two registered books, [John, Proverbs]. You only need to type one word, capitalizing the beginning of the word.

2) Type 3: Next, you need to type the CHAPTER number. You must type the number 3 because there are only two books registered, either John or Proverbs.

3) Type or ENTER or ENTER 6: If you want to display a group of verses, you need to type the number of the final verse. However, since we have only registered verses from Proverbs 3:5 to Proverbs 3:6, it is...

4) The text of the verse or group of verses you selected will be displayed on the screen.

5) Press ENTER repeatedly according to the number of words you want to hide from the selected verse, or press ESC to stop hiding words.

6) The program will ask if you want to start over and run everything from the beginning. To do this, press ESC to exit the program completely, or press ENTER to start over and choose another verse or group of verses to continue hiding words.

7) Each time all the words in a verse are hidden, a large group of text will be displayed at the end of the program, representing the verse with each iteration that had a word hidden throughout the program. A number in the middle of this long text indicates each time Enter was pressed and a word in the verse was hidden.
*/



class Program
{
    static void Main(string[] args)
    {
    
    ConsoleKeyInfo _continuingKey = new ConsoleKeyInfo('\r', ConsoleKey.Enter, false, false, false);
        while (_continuingKey.Key == ConsoleKey.Enter && _continuingKey.Key != ConsoleKey.Escape) // Continue using Enter type ESC to exit
        {

            string _book;
            int _chapter;
            int _verse;
            int _endVerse;
            string _versicle; //TEXT OF THE VERSICLE SELECTEC
            string _versicleShorted = ""; //TEXT OF THE VERSICLE SELECTED WITH SOME WORDS HIDDEN
            



            Console.WriteLine("Printing the Bible Library");

            _book = "John";
            _chapter = 3;
            _verse = 16;
            Reference _reference1 = new Reference(_book, _chapter, _verse);
            Console.WriteLine();
            _versicle = _reference1.GetDisplayText();
            Console.WriteLine(_versicle);
            Console.WriteLine();


            _book = "Proverbs";
            _chapter = 3;
            _verse = 5;
            Reference _reference2 = new Reference(_book, _chapter, _verse);
            _versicle = _reference2.GetDisplayText();
            Console.WriteLine(_versicle);
            Console.WriteLine();


            _book = "Proverbs";
            _chapter = 3;
            _verse = 5;
            _endVerse = 6;
            
            Reference _reference3 = new Reference(_book, _chapter, _verse, _endVerse);
            _versicle = _reference3.GetDisplayText();
            Console.WriteLine(_versicle);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" -- The verses listed are:[ John 3:16 ], [ Proverbs 3:5 ], range from [ Proverbs 3:5 to Proverbs 3:6] --"); Console.WriteLine();
            Console.WriteLine("- Now select the exact [BOOK], [CHAPTER], [INITIAL VERSE]. Note: Type [FINAL VERSE] too if want range of verses.");

            Console.Write("Enter only the name of the BOOK:  ");
            _book = Console.ReadLine();
            Console.Write("Enter only the name of the CHAPTER:  ");
            _chapter = int.Parse(Console.ReadLine());
            Console.Write("Enter only the number of the INITIAL VERSE:  ");
            _verse = int.Parse(Console.ReadLine());
            Console.Write("Enter only the number of the FINAL VERSE if you want a range of verses, or just press ENTER:  ");
            string endVerseInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(endVerseInput))
            {
                _endVerse = -1;
            }
            else
            {
                _endVerse = int.Parse(endVerseInput);
            }
            //Console.WriteLine(_endVerse);

            if (_endVerse > -1)
            {
                Reference _reference5 = new Reference(_book, _chapter, _verse, _endVerse);
                _versicle = _reference5.GetDisplayText();
                Console.WriteLine();
                Console.WriteLine(_versicle);
                Console.WriteLine();
            }
            else
            {
                Reference _reference4 = new Reference(_book, _chapter, _verse);
                _versicle = _reference4.GetDisplayText();
                Console.WriteLine();
                Console.WriteLine(_versicle);
                Console.WriteLine();
            }

            Scripture _scripture = new Scripture();



            Word _word = new Word(_versicle);// Create the object _word based on the class Word
            ConsoleKeyInfo _continuingKey2 = new ConsoleKeyInfo('\r', ConsoleKey.Enter, false, false, false);
            int n = 0;
            
            while (_continuingKey2.Key == ConsoleKey.Enter && _continuingKey2.Key != ConsoleKey.Escape) // Continue using Enter type ESC to exit
            {

                bool allAreHidden = _word.IsHidden();
                //Console.WriteLine(allAreHidden);
                if (allAreHidden == false) // Check if all words are hidden
                {
                    _word.Hide();
                    //Console.WriteLine(allAreHidden);
                    _versicleShorted = _word.GetDisplayText();// Get the versicle with some words hidden
                    Console.WriteLine();
                    _word.Show(); // Show the versicle with some words hidden
                    n += 1;
                    Console.WriteLine();
                    //Console.WriteLine(_versicleShorted);
                    _scripture.ScriptureMethod(_word.IsHidden() , _versicleShorted);

                }

                Console.WriteLine();
                Console.WriteLine("- Type Enter to continue hiding words or ESC to stop hiding words: ");
                _continuingKey2 = Console.ReadKey(); // Capture the key typed 
            }
            //Console.WriteLine(_scripture.ScriptureMethod(0, ""));
            



















            Console.WriteLine();
            Console.WriteLine("N -Now type Enter to continue the program and ESC to exit:  ");
            _continuingKey = Console.ReadKey(); // Capture the key typed 
            if (_continuingKey.Key == ConsoleKey.Escape)
            {
                Console.Write(" -- End of the program --");

            }
        }
        

        
    }
}
