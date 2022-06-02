using System;
using System.Globalization;

namespace Aula10Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i = 0; i < vect.Length; i++)
            {
                soma += vect[i];
            }

            double media = soma / n;

            Console.WriteLine(media.ToString("f2",CultureInfo.InvariantCulture));


        }
    }
}
