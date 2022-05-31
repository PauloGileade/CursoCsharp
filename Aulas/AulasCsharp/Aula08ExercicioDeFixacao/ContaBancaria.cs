using System;
using System.Globalization;

namespace Aula08ExercicioDeFixacao
{
    internal class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria()
        {

        }

        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double depositoInicial) : this(conta, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + Titular + ", Saldo: $" + Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }


    }
}
