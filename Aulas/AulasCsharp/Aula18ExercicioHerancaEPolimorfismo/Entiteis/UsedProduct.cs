using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Aula18ExercicioHerancaEPolimorfismo.Entiteis
{
    internal class UsedProduct : Product
    {
        public DateTime Manufacture { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manuFacture)
            : base(name, price)
        {
            Manufacture = manuFacture;
        }

        public override string PriceTag()
        {
            return Name + "(used) $ " + Price.ToString("f2", CultureInfo.InvariantCulture) + "(Manufacture date: "
                + Manufacture.ToString("dd/MM/yyyy") + ")";
        }
    }
}
