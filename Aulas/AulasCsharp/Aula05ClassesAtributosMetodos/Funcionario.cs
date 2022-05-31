using System;
using System.Globalization;

namespace Aula05ClassesAtributosMetodos
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentoSalarial(double aumento)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * aumento) / 100;
        }

        public override string ToString()
        {
            return ("Funcionário:  "
                + Nome
                + ", $ "
                + SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
