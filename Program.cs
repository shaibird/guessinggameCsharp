using System;

class Program
{
    static void Main()
    {
        FavNumberQuestion();
    }

    static void FavNumberQuestion()
    {
        int magicNumber = 45;

        Console.Write("Can you guess the magic number?");
        string answer = Console.ReadLine();
        int parsedInput = int.Parse(answer);
        
        if (parsedInput == magicNumber)
        { 
            Console.WriteLine("Yayy! You guessed it!");
        }
        else
        {
            Console.WriteLine("Ha. SO wrong.");
        }
    }
}
