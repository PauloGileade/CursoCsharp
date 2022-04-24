using System;
using System.Globalization;

namespace Projeto06 {
    class Program {
        static void Main(string[] args) {

            Estudante estudante = new Estudante();

            Console.Write("Nome: ");
            estudante.Nome = Console.ReadLine();

            for (int cont = 0; cont < estudante.Notas.Length; cont++) {

                Console.Write($"Digite a {cont + 1}° nota: ");
                estudante.Notas[cont] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine(estudante);
        }
    }
}