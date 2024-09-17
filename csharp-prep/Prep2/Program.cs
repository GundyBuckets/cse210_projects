using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);

        if (grade >= 90)
        {
            Console.WriteLine("Your letter grade is A");
        } 
        else if (grade >= 80)
        {
            Console.WriteLine("Your letter grade is B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your letter grade is C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your letter grade is D");
        }
        else if (grade < 60)
        {
            Console.WriteLine("Your letter grade is F");
        }
    }
}