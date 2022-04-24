using System;
using System.Globalization;

namespace Projeto09Sobrecarga {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        public double ValorTotalEstoque() {

            return Preco * Quantidade;
        }

        public void AdcionarProdutos(int qtd) {

            Quantidade += qtd;
        }

        public void RemoverProdutos(int qtd) {

            Quantidade -= qtd;
        }

        public override string ToString() {

            return Nome
                + ", $ "
                + Preco.ToString("f2", CultureInfo.InvariantCulture) + ", "
                + Quantidade
                + " unidades , Total: $ "
                + ValorTotalEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
