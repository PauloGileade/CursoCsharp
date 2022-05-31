using System;
using System.Globalization;

namespace Aula03ClassesAtributosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Dados do produto: "+produto);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtd);
            Console.WriteLine();
            Console.Write("Dados do atualizados: " + produto);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtd);
            Console.Write("Dados do atualizados: " + produto);
        }
    }
}
