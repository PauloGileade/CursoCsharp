using System;

namespace Aula14ExercicioMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("informe o tamanho da matriz: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[,] matriz = new int[tamanho, tamanho];
            int negative = 0;

            for (int linha = 0; linha < tamanho; linha++)
            {
                for (int coluna = 0; coluna < tamanho; coluna++)
                {
                    Console.Write("\nDigite um valor para preencher a matriz: ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (matriz[linha, coluna] < 0)
                    {
                        negative++;
                    }
                }
            }
            Console.WriteLine("Main Diagonal: ");
            for (int linha = 0; linha < tamanho; linha++)
            {
                for (int coluna = 0; coluna < tamanho; coluna++)
                {
                    if (linha == coluna)
                    {
                        Console.Write("[" + matriz[linha, coluna] + "]");
                    }
                    else
                    {
                        Console.Write("[*]");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("Negative numbers: " + negative);

        }
    }
}
