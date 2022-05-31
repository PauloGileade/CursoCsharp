using System;
using System.Globalization;

namespace Aula06ClassesAtributosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            for(int i = 1; i <= 3; i++)
            {
                Console.Write($"Digite a nota do {i} aluno: ");
                double nota = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                aluno.SomaNota(nota);
            }

            Console.Write(aluno);
            Console.WriteLine();

            if (aluno.Notas > 60)
            {
                Console.Write("Aprovado");
            }
            else
            {
                aluno.Notas -= 60;
                Console.Write("Reprovado\nFaltaram "+aluno.Notas.ToString("f2",CultureInfo.InvariantCulture)+" Pontos");
            }
        }
    }
}
