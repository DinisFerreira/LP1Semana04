using System;

namespace BetterDecorator
{
    class Program
  {
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: Program.exe <string> <char> <int>");
            return;
        }

        string input = args[0];
        if (input.Length == 0)
        {
            Console.WriteLine("String cannot be empty.");
            return;
        }

        char decorator;
        if (!char.TryParse(args[1], out decorator))
        {
            Console.WriteLine("Invalid character for decoration.");
            return;
        }

        int repetitions;
        if (!int.TryParse(args[2], out repetitions) || repetitions < 0)
        {
            Console.WriteLine("Invalid number of repetitions.");
            return;
        }

        string decoratedString = Decor(input, decorator, repetitions);
        Console.WriteLine(decoratedString);
    }

    static string Decor(string input, char decorator, int repetitions)
    {
        string decoration = new string(decorator, repetitions);
        return decoration + input + decoration;
    }
  }
}
