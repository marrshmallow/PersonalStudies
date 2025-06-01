using System;

class PrimeFactorization
{ 
  // A function to print all prime factors of a given number n
  // https://www.geeksforgeeks.org/print-all-prime-factors-of-a-given-number/
  private static void printPrimeFactors(int n)
  {
    Console.Write($"Prime factors of {n}, in their exponent form:\n\n");

    int count = 0;
    
    while (n % 2 == 0)
    {
      count++;
      n /= 2;
    }

    if (count > 0)
    {
      Console.WriteLine($"2^{count}");
    }

    // n is always odd here so skip one element
    // i * i <= n reduces redundant calculation
    for (int i = 3; i * i <= n; i += 2)
    {
      count = 0;
      
      while (n % i == 0)
      {
        count++;
        n /= i;
      }

      if (count > 0)
      {
        Console.WriteLine($"{i}^{count}");
      }
    }

    if (n > 1)
    {
      Console.WriteLine($"{n}^1");
    }

    Console.WriteLine("=== END ===");
  }

  private static void Main()
  {
    int n = 1228;
    printPrimeFactors(n);
  }
}
