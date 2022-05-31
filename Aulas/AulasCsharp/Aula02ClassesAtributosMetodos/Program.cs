using System;
using System.Globalization;

namespace Aula02ClassesAtributosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Funcionario funcionario1 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario.Salario + funcionario1.Salario) / 2;

            Console.WriteLine("Salário médio: " + media.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
