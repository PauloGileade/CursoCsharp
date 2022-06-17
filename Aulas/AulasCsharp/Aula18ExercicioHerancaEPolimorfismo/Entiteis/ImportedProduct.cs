using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Aula18ExercicioHerancaEPolimorfismo.Entiteis
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customs)
            : base(name, price)
        {
            CustomsFee = customs;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("f2", CultureInfo.InvariantCulture)
                + "( Customs fee: $ " + CustomsFee.ToString("f2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
