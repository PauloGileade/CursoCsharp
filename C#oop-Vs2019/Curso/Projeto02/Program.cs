using System;
using System.Globalization;

namespace Projeto02 {
    class Program {
        static void Main(string[] args) {

            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário !");
            Console.Write("Nome: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionário !");
            Console.Write("Nome: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("-------------------------");

            funcionario1.imprime();
            funcionario2.imprime();

            double media = funcionario1.salario + funcionario2.salario;
            media /= 2;

            Console.WriteLine("-------------------------");
            Console.WriteLine("Salário médio: " + media.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
