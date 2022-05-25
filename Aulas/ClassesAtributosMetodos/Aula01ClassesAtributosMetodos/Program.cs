using System;

namespace Aula01ClassesAtributosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            if(pessoa.Idade > pessoa1.Idade)
            {
                Console.WriteLine($"Pessoal mais velha: {pessoa.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoal mais velha: {pessoa1.Nome}");
            }
        }
    }
}
