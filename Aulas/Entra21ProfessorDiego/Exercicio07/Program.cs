using System;
using System.Globalization;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("informe a distancia percorrida pelo automovel: ");
            double percorrido = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Informe o total de combustivel gasto: ");
            double combustivel = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double consumo = percorrido / combustivel;

            Console.WriteLine("Consumo do veiculo = "+consumo.ToString("f2"),CultureInfo.InvariantCulture);
        }
    }
}
