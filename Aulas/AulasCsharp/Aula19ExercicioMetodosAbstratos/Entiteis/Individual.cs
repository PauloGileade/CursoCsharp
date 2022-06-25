using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19ExercicioMetodosAbstratos.Entiteis
{
    internal class Individual : TaxPayer
    {
        public double GastoSaude { get; set; }

        public Individual(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Imposto()
        {
            if(RendaAnual <= 20000)
            {
                return (RendaAnual * 0.15) - (GastoSaude * 0.50);
            }
            else
            {
                return (RendaAnual * 0.25) - (GastoSaude * 0.50);
            }
        }
    }
}
