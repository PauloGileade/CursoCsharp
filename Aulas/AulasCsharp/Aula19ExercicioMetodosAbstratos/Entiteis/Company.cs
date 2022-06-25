using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19ExercicioMetodosAbstratos.Entiteis
{
    internal class Company : TaxPayer
    {
        public int NumFuncionarios { get; set; }

        public Company(int numFuncionarios, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            NumFuncionarios = numFuncionarios;
        }

        public override double Imposto()
        {
            if(NumFuncionarios > 10)
            {
                return (RendaAnual * 0.14);
            }
            else
            {
                return (RendaAnual * 0.16);
            }
        }
    }
}
