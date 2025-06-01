using System;

class GcdEuclidean
{
  // https://stackoverflow.com/a/79329978
  private static int CalculateGcd(int a, int b)
  {
    int quotient = Math.Abs(a);
    int remainder = Math.Abs(b);
    
    while (remainder != 0)
    {
      int temp = quotient % remainder;
      quotient = remainder;
      remainder = temp;
    }
    
    return quotient; // returning here the second-last quotient that was non-zero, which is the gcd
  }
  
  private static void Main()
  {
    int a = 214;
    int b = 1228;
    int gcd = CalculateGcd(a, b);
    Console.WriteLine($"GCD of {a} and {b} is {gcd}");
  }
}
