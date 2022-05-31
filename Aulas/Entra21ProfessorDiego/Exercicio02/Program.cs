using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[2];
            int soma = 0;
            for(int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite {i+1}° número: ");
                num[i] = int.Parse(Console.ReadLine());

                soma += num[i];
            }
            Console.WriteLine($"A soma é = {soma}");
        }
    }
}
