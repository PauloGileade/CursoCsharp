using System;
using System.Globalization;

namespace Projeto16Vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] vetor = new double[4];
            double media = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite {i+1} nota: ");
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                media += vetor[i];
            }
            media /= vetor.Length;

            if(media > 6)
            {
                Console.Write($"Média {media.ToString("f2")} Aluno aprovado !");
            }
            else
            {
                Console.Write($"Média {media.ToString("f2")} Aluno reprovado !");
            }
        }
    }
}