using System;
using System.Globalization;
using System.Collections.Generic;

namespace Aula13ExercicoDeLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hom many employees will be registered ?");
            int registered = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < registered; i++)
            {
                Console.WriteLine($"Emplyoee #{i + 1}");
                Console.Write("\nId: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("\nName: ");
                string name = Console.ReadLine();
                Console.Write("\nSalary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, name, salary));
            }
            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int number = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == number);

            if (number != null)
            {
                Console.Write("\nEnter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emp.Aumento(percentage);
            }
            else
            {
                Console.Write("\nThis id does not exist !");
            }

            Console.Write("Updated list of employees: ");
            Console.WriteLine();
            foreach (Funcionario funcionario in list)
            {
                Console.WriteLine(funcionario);
            }


        }
    }
}
