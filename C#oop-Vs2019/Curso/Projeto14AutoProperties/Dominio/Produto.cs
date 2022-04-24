using System;
using System.Globalization;

namespace Projeto14AutoProperties.Dominio {
    class Produto {

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        public Produto() {

        }
        public Produto(string nome, double preco, int quantidade) {

            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public string Nome {

            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {

                    _nome = value;
                }
            }
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

            return _nome
                + ", $ "
                + Preco.ToString("f2", CultureInfo.InvariantCulture) + ", "
                + Quantidade
                + " unidades , Total: $ "
                + ValorTotalEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
