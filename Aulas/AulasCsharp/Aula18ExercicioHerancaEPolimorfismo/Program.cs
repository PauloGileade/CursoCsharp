using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula18ExercicioHerancaEPolimorfismo.Entiteis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char resposta = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resposta == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customs));
                }
                else if (resposta == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime manuFacture = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manuFacture));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
