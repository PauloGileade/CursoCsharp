using System;

namespace Aula15ExercicioMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("informe a quantidade de linhas da matriz: ");
            int qtdLinha = int.Parse(Console.ReadLine());
            Console.Write("informe a quantidade de colunas da matriz: ");
            int qtdColuna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[qtdLinha, qtdColuna];
            Console.Clear();

            for (int linha = 0; linha < qtdLinha; linha++)
            {
                for (int coluna = 0; coluna < qtdColuna; coluna++)
                {
                    Console.Write("Digite um valor para preencher a matriz: ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }
            for (int linha = 0; linha < qtdLinha; linha++)
            {
                for (int coluna = 0; coluna < qtdColuna; coluna++)
                {
                    Console.Write("[" + matriz[linha, coluna] + "]");
                }
                Console.WriteLine();
            }
            Console.Write("\nEsccolha um valor da matriz: ");
            int num = int.Parse(Console.ReadLine());

            for (int linha = 0; linha < qtdLinha; linha++)
            {
                for (int coluna = 0; coluna < qtdColuna; coluna++)
                {

                    if (matriz[linha, coluna] == num)
                    {
                        Console.WriteLine("Position " + linha + "," + coluna + ":");
                        if (coluna > 0)
                        {
                            Console.WriteLine("Left: " + matriz[linha, coluna - 1]);
                        }
                        if (linha > 0)
                        {
                            Console.WriteLine("Up: " + matriz[linha - 1, coluna]);
                        }
                        if (coluna < qtdColuna - 1)
                        {
                            Console.WriteLine("Right: " + matriz[linha, coluna + 1]);
                        }
                        if (linha < qtdLinha - 1)
                        {
                            Console.WriteLine("Down: " + matriz[linha + 1, coluna]);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
