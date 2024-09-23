using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorie number: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static int SquareNumber(int num)
        {
            int sqr = num * num;
            return sqr;
        }

        static void DisplayResult(string name, int num)
        {
            Console.WriteLine(name + ", the square of your number is " + num);
        }

        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int sqr = SquareNumber(num);
        DisplayResult(name, sqr);
        
    }
}