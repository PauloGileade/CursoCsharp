using System;
using System.Globalization;

namespace Projeto15ExercicioContaBancaria.Dominio {
    class Program {
        static void Main(string[] args) {

            ContaBancaria dados = new ContaBancaria();

            Console.Write("Digite o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s/n)? ");
            char confirmacao = char.Parse(Console.ReadLine());

            if (confirmacao == 's') {

                Console.Write("Digite o valor de depósito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                dados = new ContaBancaria(conta, titular, valor);
            }
            else if (confirmacao == 'n') {

                dados = new ContaBancaria(conta, titular);
            }

            Console.Write("\nDados da conta: " + dados);

            Console.Write("\n\nDigite um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.Deposito(quantia);

            Console.Write("\nDados da conta atualizados: " + dados);

            Console.Write("\n\nDigite um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.Saque(quantia);

            Console.Write("\nDados da conta atualizados: " + dados);

        }
    }
}
