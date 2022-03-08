using System;

namespace Primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int compara=0;

            Console.WriteLine("Digite um numero qualquer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2;i < n; i++)
            {
                if (n%i == 0)
                    compara ++;
            }

            if (compara == 0)
                Console.WriteLine($"\n{n} é um numero primo!!");
            else
                Console.WriteLine($"\n{n} não é um numero primo.\n\n");
        }
    }
}
