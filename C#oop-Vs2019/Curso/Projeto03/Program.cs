using System;
using System.Globalization;

namespace Projeto03 {
    class Program {
        static void Main(string[] args) {

            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto !");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.Write($"\nDados do produto: {produto}");
            Console.Write("\n\nDigite o número de produtos a ser adicionado no estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdcionarProdutos(qtd);
            Console.WriteLine("\n");
            Console.Write($"Dados atualizados: {produto}");
            Console.WriteLine("\n");
            Console.Write("\nDigite o número de produtos a ser retirado do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtd);
            Console.WriteLine("\n");
            Console.Write($"Dados atulizados: {produto}");
        }
    }
}
