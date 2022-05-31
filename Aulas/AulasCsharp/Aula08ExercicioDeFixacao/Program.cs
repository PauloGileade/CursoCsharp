using System;
using System.Globalization;

namespace Aula08ExercicioDeFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria();

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n): ");
            char resposta = char.Parse(Console.ReadLine());


            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre com valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                contaBancaria = new ContaBancaria(conta, titular, deposito);
            }
            else if (resposta == 'n' || resposta == 'N')
            {
                contaBancaria = new ContaBancaria(conta, titular);
            }
            Console.WriteLine();
            Console.Write("Dados da conta: \n" + contaBancaria);
            Console.WriteLine();
            Console.Write("\nEntre com valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(valor);
            Console.WriteLine();
            Console.Write("Dados da conta atualizados: \n" + contaBancaria);
            Console.WriteLine();
            Console.Write("\nEntre com valor para Saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(valor);
            Console.WriteLine();
            Console.Write("Dados da conta atualizados: \n" + contaBancaria);
        }
    }
}
