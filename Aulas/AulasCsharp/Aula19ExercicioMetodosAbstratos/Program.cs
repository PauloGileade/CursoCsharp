using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula19ExercicioMetodosAbstratos.Entiteis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data: ");
                Console.Write("Individual or company (i/c) ? ");
                Console.Write("Individual or company (i/c) ? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, income, expenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(numberEmployees, name, income));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Nome + ": $ " + taxPayer.Imposto().ToString("f2", CultureInfo.InvariantCulture));

                sum += taxPayer.Imposto();
            }
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
