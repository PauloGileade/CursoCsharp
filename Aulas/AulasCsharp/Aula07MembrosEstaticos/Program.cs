using System;
using System.Globalization;

namespace Aula07MembrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double result = ConversorDeMoedas.Pagar(cotacao, quantia);

            Console.WriteLine();

            Console.WriteLine("Valor a ser pago em reais: "+result.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}