using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano que você nasceu: ");
            int nascimento = int.Parse(Console.ReadLine());

            int idade = anoAtual - nascimento;

            Console.Write($"Sua idade é = {idade}");
        }
    }
}
