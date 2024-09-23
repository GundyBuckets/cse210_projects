using System;

class Program
{
    static void Main(string[] args)
    {        
        Console.Write("What is the magic number? ");
        var magic_number = int.Parse(Console.ReadLine());
        int guess;
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magic_number) 
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magic_number);
    }
}