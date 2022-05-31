using System;
using System.Globalization;

namespace Aula07MembrosEstaticos
{
    internal class ConversorDeMoedas
    {
        public static double IOF = 0.06;


        public static double Pagar(double cotacao, double quantia )
        {
            return (cotacao * quantia) + ((cotacao * quantia) * IOF);
        }
    }
}
