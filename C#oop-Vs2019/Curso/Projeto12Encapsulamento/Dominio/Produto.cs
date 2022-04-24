using System;
using System.Globalization;

namespace Projeto12Encapsulamento.Dominio {
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
        public string GetNome() {

            return _nome;
        }
        public void SetNome(string nome) {

            if (nome != null && nome.Length > 1) {

                _nome = nome;
            }
        }
        public double GetPreco() {

            return _preco;
        }
        public int GetQuantidade() {

            return _quantidade;
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
