using System;
using System.Globalization;

namespace Projeto05 {
    class Program {
        static void Main(string[] args) {

            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"\n{funcionario}");
            Console.WriteLine("\n------------------------------");
            Console.Write("Digite a porcentagem para aumnetar o salário: ");
            double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(perc);
            Console.WriteLine("\n------------------------------");
            Console.WriteLine($"\n{funcionario}");
        }
    }
}
