using System;
using System.Globalization;

namespace Projeto03 {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

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
