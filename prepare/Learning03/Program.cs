using System;

class Program
{
    static void Main(string[] args)
    {
        // First fraction is 1/1
        Fraction firstNum = new();
        Console.WriteLine(firstNum.GetFractionString());
        Console.WriteLine(firstNum.GetDecimalValue());

        // Second fraction is 5/1
        Fraction secondNum = new Fraction(5);
        Console.WriteLine(secondNum.GetFractionString());
        Console.WriteLine(secondNum.GetDecimalValue());

        // Third fraction is 3/4
        Fraction thirdNum = new Fraction(3, 4);
        Console.WriteLine(thirdNum.GetFractionString());
        Console.WriteLine(thirdNum.GetDecimalValue());

        // Fourth fraction is 1/3
        Fraction fourthNum = new Fraction(1, 3);
        Console.WriteLine(fourthNum.GetFractionString());
        Console.WriteLine(fourthNum.GetDecimalValue());
    }
}