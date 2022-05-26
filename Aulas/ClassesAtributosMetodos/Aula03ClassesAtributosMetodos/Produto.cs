using System;
using System.Globalization;

namespace Aula03ClassesAtributosMetodos
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double Total()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", " + "$ "
                + Preco.ToString("f2", CultureInfo.InvariantCulture)
                + ", " + Quantidade
                + " unidades" + ", Total: $" + Total().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
