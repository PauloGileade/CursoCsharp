using System;
using System.Globalization;

namespace Projeto13Properties.Dominio {
    class Produto {

        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto() {

        }
        public Produto(string nome, double preco, int quantidade) {

            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string Nome {

            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {

                    _nome = value;
                }
            }
        }
        public double Preco {

            get { return _preco; }
        }
        public int Quantidade {

            get { return _quantidade; }
        }
        public double ValorTotalEstoque() {

            return _preco * _preco;
        }
        public void AdcionarProdutos(int qtd) {

            _quantidade += qtd;
        }
        public void RemoverProdutos(int qtd) {

            _quantidade -= qtd;
        }
        public override string ToString() {

            return _nome
                + ", $ "
                + _preco.ToString("f2", CultureInfo.InvariantCulture) + ", "
                + _quantidade
                + " unidades , Total: $ "
                + ValorTotalEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
