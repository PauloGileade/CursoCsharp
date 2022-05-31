using System;
using System.Globalization;

namespace Aula04ClassesAtributosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com os dados do retangulo:");
            retangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.WriteLine(retangulo);
        }
    }
}
