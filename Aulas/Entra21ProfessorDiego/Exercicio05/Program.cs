using System;
using System.Globalization;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu salário fixo: ");
            double salFixo = double.Parse(Console.ReadLine());
            Console.Write("Informe seu total de vendas em dinheiro: ");
            double totalVendas = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write($"Nome: {nome}");
            Console.Write("\nSalário fixo: "+salFixo.ToString("f2"));

            double comissao = (totalVendas*15)/100 ;
            double newSal = salFixo + comissao;

            Console.Write("\nSalário final do mês: "+newSal);
        }
    }
}
