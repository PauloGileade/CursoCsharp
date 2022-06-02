using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media = 7;

            if(media >= 7)
                Console.WriteLine("aprovado");
            else if(media >=5)
                Console.WriteLine("recuperação");
            else
                Console.WriteLine("reprovado");
        }
    }
}
