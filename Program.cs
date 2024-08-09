
using System.Security.AccessControl;
using System.Xml;
bool restart;

Console.WriteLine("Welcome to the Pig Latin Translator App");

do
{
   StartProgram();
   restart = StartProgram();
}
while (restart == true);


/*
1 Point: If a word starts with a vowel, just add “way” onto the ending.
2 Point: if a word starts with a consonant, move all of the consonants 
that appear before the first vowel to the end of the word, then add “ay” to the end of the word. 

*/



 static bool StartProgram()
{
    bool restart = true;
    string userInput = "";
    string before = "";
    string after = "";




    do
    {
        Console.WriteLine("Enter a line to be translated");
        userInput = Console.ReadLine().Trim();  //removed .lower()
    }
    while (userInput == "");   //makes sure the user enters a string




    string[] words = userInput.Split(' ');

    foreach(string newsplit in words)
        {
        string newInput = "";

        for (int i = 0; i < newsplit.Length; i++)
        {
            char currentLetter = newsplit[i];
            //maintains upper and lower casing
            if (currentLetter == 'a' || currentLetter == 'e' || currentLetter == 'i' || currentLetter == 'o' || currentLetter == 'u' || currentLetter == 'A' || currentLetter == 'E' || currentLetter == 'I' || currentLetter == 'O' || currentLetter == 'U')
            {
                if (i == 0)
                {
                    newInput = newsplit + "way";
                    break;
                }
                else
                {
                before = newsplit.Substring(0, i);
                after = newsplit.Substring(i);
                newInput = after + before + "ay";
                break;
                }
            }
            else
            {
               
            }
            
        }
        Console.Write($"{newInput} ");
    }

    Console.WriteLine("\nTranslate another line y/n?");
    string tryAgain = Console.ReadLine();
    if (tryAgain == "y" || tryAgain == "Y")

    {
        return true;
    }

    else
    {
        return false;
        
    }

}



