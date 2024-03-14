using System;

namespace BetterDecorator
{
    class Program
    {
  static void Main(string[] args)
    {
        string decoratedString = Decor("Hello", '*', 3);
        Console.WriteLine(decoratedString); 
    }

    static string Decor(string input, char decorator, int repetitions)
    {
        string decoration = new string(decorator, repetitions);
        return decoration + input + decoration;
    }
    }
}
