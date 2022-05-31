using System;
using System.Globalization;

namespace Aula06ClassesAtributosMetodos
{
    internal class Aluno
    {
        public string Nome;

        public double Notas;

        public void SomaNota(double nota)
        {
            Notas += nota;
        }

        public override string ToString()
        {
            return "Nota final: " + Notas.ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
