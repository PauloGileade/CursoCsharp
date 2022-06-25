using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19ExercicioMetodosAbstratos.Entiteis
{
    internal abstract class TaxPayer
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        protected TaxPayer(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
    }
}
