using System;

namespace Projeto02 {
    class Funcionario {

        public string nome;
        public double salario;

        public void imprime() {

            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Salário: {this.salario}");
        }
    }
}
