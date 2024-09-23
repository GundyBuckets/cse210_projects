using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int new_num;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        do
        {
            Console.Write("Enter number: ");
            new_num = int.Parse(Console.ReadLine());
            if (new_num != 0)
            {
                numbers.Add(new_num);
            }
        } while (new_num != 0);

        int sum = 0;
        foreach (int num in numbers) 
        {
            sum += num;
        }
        Console.WriteLine("The sum is: " + sum);

        double avg = (double)sum / numbers.Count;
        Console.WriteLine("The average is: " + avg);

        int max = 0;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine("The largest number is: " + max);
    }
}