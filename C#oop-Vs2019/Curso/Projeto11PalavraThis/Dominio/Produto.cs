using System;
using System.Globalization;

namespace Projeto11PalavraThis {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;
        public Produto() {

            Quantidade = 10;
        }
        public Produto(string nome, double preco) : this() {

            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {

            Quantidade = quantidade;
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
