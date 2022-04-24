using System;
using System.Globalization;

namespace Projeto06 {
    class Estudante {

        public string Nome;
        public Double[] Notas = new double[3];
        public double NotasFinal() {

            double soma = 0;
            for (int i = 0; i < Notas.Length; i++) {

                soma += Notas[i];
            }
            return soma;
        }
        public string Resposta() {

            if (NotasFinal() >= 60) {

                return "Aprovado";
            }
            else {

                return "Reprovado";
            }
        }
        public double NotaFaltante() {

            return 60 - NotasFinal();
        }
        public override string ToString() {

            return ("NOTA FINAL = "
                + NotasFinal().ToString("f2", CultureInfo.InvariantCulture)
                + "\n" + Resposta()
                 + $"\nFALTARAM {NotaFaltante().ToString("f2", CultureInfo.InvariantCulture)} PONTOS");
        }
    }
}
