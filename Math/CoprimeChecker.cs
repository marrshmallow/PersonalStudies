using System;

class CoprimeChecker
{
  private static bool AreCoprime(int a, int b)
  {
    int numA = Math.Abs(a);
    int numB = Math.Abs(b);
    
    if (numA == 0 || numB == 0)
    {
      return false;
    }

    while (numB != 0)
    {
      int temp = numB;
      numB = numA % numB;
      numA = temp;
    }

    return numA == 1;
  }

  private static void Main(string[] args)
  {
    int a = 15;
    int b = 23;
    bool result = AreCoprime(a, b);
    Console.WriteLine($"Q: Are {a} and {b} coprime?\nA: {result}");
  }
}
