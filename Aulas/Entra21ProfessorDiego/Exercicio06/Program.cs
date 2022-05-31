using System;

namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do produto: ");
            string produto = Console.ReadLine();
            Console.Write("digite valor da compra: ");
            double valor = double.Parse(Console.ReadLine());

            double parcela = valor / 5;

            Console.WriteLine("valor a ser pago em 5x vezes sem juros = "+parcela);
        }
    }
}
