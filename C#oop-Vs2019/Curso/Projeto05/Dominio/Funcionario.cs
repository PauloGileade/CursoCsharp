using System;
using System.Globalization;

namespace Projeto05 {
    class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {

            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double perc) {

            SalarioBruto = SalarioBruto + (SalarioBruto * perc) / 100;
        }
        public override string ToString() {
            return ("Funcionário:  "
                + Nome
                + ", $ "
                + SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}

