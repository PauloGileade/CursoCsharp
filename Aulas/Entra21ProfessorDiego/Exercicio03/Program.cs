using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int soma = 0, sub = 0, multi = 0, div = 0;

            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            int num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;
            sub = num1 - num2;
            multi = num1 * num2;
            div = num1 / num2;

            Console.WriteLine($"A Soma é = {soma}");
            Console.WriteLine($"A Subtração é = {sub}");
            Console.WriteLine($"A Multiplicação é = {multi}");
            Console.WriteLine($"A Divisão é = {div}");
        }
    }
}
