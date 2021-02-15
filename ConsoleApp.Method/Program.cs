using System;

namespace ConsoleApp.Method
{
  class Program
  {
    static void Main(string[] args)
    {
      var person1 = new Person("Kuzmin", "Vladimir");
      var person2 = new Person("Lavrentiev", "Mikhail");
      for (int i = 0; i < 10; i++)
      {
        var position1 = person1.Move();
        Console.WriteLine(position1);

        var position2 = person2.Move(1, 1);
        Console.WriteLine(position2);
      }

      Console.WriteLine($"Factorial: {Factorial(5)}");
      Console.ReadLine();
    }

    public static int Factorial(int value)
    {
      if (value <= 1)
        return 1;
      else
      {
        return value * Factorial(value - 1);
      }
    }

  }
}
