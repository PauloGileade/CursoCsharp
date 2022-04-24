using System;
using System.Globalization;

namespace Projeto11PalavraThis {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do produto !");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new Produto(nome, preco);

            Produto produto1 = new Produto();

            Produto produto2 = new Produto {

                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };

            Console.Write($"\nDados do produto: {produto}");

            Console.Write("\n\nDigite o número de produtos a ser adicionado no estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdcionarProdutos(qtd);

            Console.Write($"\nDados atualizados: {produto}");

            Console.Write("\n\nDigite o número de produtos a ser retirado do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtd);

            Console.Write($"\nDados atulizados: {produto}");
        }
    }
}

