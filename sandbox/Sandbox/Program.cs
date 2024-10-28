using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        long N = long.Parse(input[0]);
        long K = long.Parse(input[1]);

        long[] elasticity = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

        // Prime factorization and inclusion-exclusion
        Dictionary<long, int> primeFactors = new Dictionary<long, int>();
        foreach (long ball in elasticity)
        {
            long num = ball;
            for (long i = 2; i * i <= num; i++)
            {
                while (num % i == 0)
                {
                    if (primeFactors.ContainsKey(i))
                    {
                        primeFactors[i]++;
                    }
                    else
                    {
                        primeFactors.Add(i, 1);
                    }
                    num /= i;
                }
            }
            if (num > 1)
            {
                if (primeFactors.ContainsKey(num))
                {
                    primeFactors[num]++;
                }
                else
                {
                    primeFactors.Add(num, 1);
                }
            }
        }

        // Calculate the count using inclusion-exclusion principle
        long count = 0;
        foreach (var pair in primeFactors)
        {
            long prime = pair.Key;
            long power = pair.Value;

            // Calculate the number of multiples of prime^i up to N
            for (int i = 1; i <= power; i++)
            {
                count += N / (long)Math.Pow(prime, i);
            }
        }

        // Apply inclusion-exclusion principle for combinations of prime factors
        // (Implement the logic based on the specific problem constraints and the number of prime factors)

        Console.WriteLine(count);
    }
}