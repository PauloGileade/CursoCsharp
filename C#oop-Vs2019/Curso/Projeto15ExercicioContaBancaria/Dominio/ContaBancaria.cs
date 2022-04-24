using System;
using System.Globalization;

namespace Projeto15ExercicioContaBancaria.Dominio {
    class ContaBancaria {

        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double SaldoConta { get; private set; }

        public ContaBancaria() {


        }
        public ContaBancaria(int conta, string titular) {

            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double valor) : this(conta, titular) {

            SaldoConta = valor;
        }

        public void Deposito(double entrada) {

            SaldoConta += entrada;
        }

        public void Saque(double saida) {

            SaldoConta -= saida + 5.00;
        }
        public override string ToString() {

            return
                "\nConta "
                + Conta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + SaldoConta.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
