using System;
using System.Globalization;

namespace Projeto07 {
    class Program {
        static void Main(string[] args) {


            Console.Write("Qual é a cotação do dólar ? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar: ");
            double comprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pagar = ConversorDeMoeda.DolarParaReal(cotacao, comprar);

            Console.WriteLine("Valor a ser pago em reais: "+pagar.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
