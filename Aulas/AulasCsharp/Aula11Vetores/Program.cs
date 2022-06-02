using System;
using System.Globalization;

namespace Aula11Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product(name, price);
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }

            double media = soma / n;
            Console.WriteLine("AVERAGE PRICE = "+media.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
