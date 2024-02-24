using System;

class Program {
  public static void Main (string[] args) {
    int num;
    while (true)
    {
      Console.WriteLine("Enter a number (or 0 to exit): ");
      string sam = Console.ReadLine();

      if (int.TryParse(sam, out num))
      {
        if (num == 0)
          {
            Console.WriteLine("Program Terminated. ");
            break;
            }
        else if (num ==0)
        {
          break;
        }

        {
          printTriangle(num);
        }
    }
    else
      { 
     Console.WriteLine($"Invalid Value : {sam}. ");
      }
    }
  }
  static void printTriangle(int n)
  {
    for (int i = 1; i <= n; i++)
    {
      for (int j = 1; j <= n - i; j++)
      {
        Console.Write(" ");
      }
      for (int k = 1; k <=2 * i - 1; k++)
      {
        Console.Write("*");
      }
      Console.WriteLine();
    }
  }  
}