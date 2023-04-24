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
    int numAttempts = 4;
    
    for (int i = 0; i < numAttempts; i++)
    {
        Console.Write("Can you guess the magic number? ");
        string answer = Console.ReadLine();
        int parsedInput;

        if (!int.TryParse(answer, out parsedInput))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            i--;
            continue;
        }
        
        if (parsedInput == magicNumber)
        { 
            Console.WriteLine("Yayy! You guessed it!");
            return;
        }
        else
        {
            Console.WriteLine("Wrong answer. Try again.");
        }
    }

    Console.WriteLine("You have run out of attempts. The magic number was {0}.", magicNumber);
}

}
