using System;

namespace SpecialSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o número n da sequência especial: ");
            int n = int.Parse(Console.ReadLine());
            
            // Invoca o método GetSpecial
            Console.WriteLine(GetSpecial(n));
        }

        /// <summary>
        /// Calcula o n-ésimo número da sequência especial.
        /// </summary>
        /// <param name="n">O número da posição na sequência.</param>
        /// <returns>O n-ésimo número da sequência especial.</returns>
        private static int GetSpecial(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else if (n == 2)
                return 3;
            else
                return 2 * GetSpecial(n - 1) + GetSpecial(n - 2) - GetSpecial(n - 3);
        }
    }
}
