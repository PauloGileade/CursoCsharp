using System;
using System.Globalization;
using System.Collections.Generic;

namespace Aula17ExercicioHerancaEPolimorfismo.Entiteis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Employee {i + 1} data");
                Console.Write("Outsourced (y/n) ?");
                char resposta = char.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Value per hours: ");
                double valueHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resposta == 'y')
                {
                    Console.WriteLine("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valueHours, additional));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueHours));
                }
            }
            Console.WriteLine();
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " $" + emp.Payment().ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}
