using System;

class Program
{
    static void Main(string[] args)
    {
    Random random = new Random();
    int magic_number = random.Next(1, 100);

    int guess_number = -1;
    
    int guess_count = 0;
    
    while (guess_number != magic_number)
    {
    Console.WriteLine("What is your guess number?");
    string g_number = Console.ReadLine();
    guess_number = int.Parse(g_number);
    if(guess_number == magic_number)
    {
        Console.WriteLine("Congratulations! You guessed it right!");
    }
        else if (guess_number > magic_number)
            {
                Console.WriteLine("Thanks for trying! You may repeat but LOWER your guess.");
            }
            else if (guess_number < magic_number)
            {
                Console.WriteLine("Thanks for trying! You may repeat but HIGHER your guess" );
            }

    guess_count++;
    Console.WriteLine($"Score = {guess_count}");
    }
    int final_score = 100 - ((guess_count-1)*1);
    if (final_score < 0)
    {
        final_score = 0;
    
    }
    Console.Write($"You took {guess_count} guesses. ");
    Console.WriteLine($"Your final performance score: {final_score} points!");
    }
    }