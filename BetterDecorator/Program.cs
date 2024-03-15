using System;

namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// Método para decorar uma string com um caractere específico repetido um número de vezes em cada lado.
        /// </summary>
        /// <param name="s">A string a ser decorada.</param>
        /// <param name="dec">O caractere de decoração.</param>
        /// <param name="num">O número de vezes que o caractere de decoração deve aparecer de cada lado.</param>
        /// <returns>A string decorada.</returns>
        private static string Decor(string s, char dec, int num)
        {
            string decoration = new string(dec, num);
            return $"{decoration}{s}{decoration}";
        }
        
        /// <summary>
        /// Método principal para executar o programa.
        /// </summary>
        /// <param name="args">Os argumentos passados na linha de comando.</param>
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: dotnet run --project BetterDecorator <string> <char> <int>");
                return;
            }

            string text = args[0];
            char decorationChar = args[1][0];
            int times;
            if (!int.TryParse(args[2], out times))
            {
                Console.WriteLine("Invalid number of repetitions.");
                return;
            }

            Console.WriteLine(Decor(text, decorationChar, times));
        }
    }
}
