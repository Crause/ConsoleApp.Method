using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Method
{
  class Person
  {
    public string SecondName { get; set; }
    public string Name { get; set; }

    public int X { get; set; }
    public int Y { get; set; }


    public Person(string secondName, string name)
    {
      SecondName = secondName;
      Name = name;

      X = 0;
      Y = 0;
    }
    public string Move()
    {
      var rnd = new Random();

      X += rnd.Next(-2, 2);
      Y += rnd.Next(-2, 2);

      return $"{Name} ({X}, {Y})";
    }

    public string Move(int x, int y)
    {
      X += x;
      Y += y;

      return $"{Name} ({X}, {Y})";
    }
  }
}
