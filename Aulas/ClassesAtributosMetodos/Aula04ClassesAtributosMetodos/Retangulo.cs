using System;
using System.Globalization;

namespace Aula04ClassesAtributosMetodos
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;


        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {   
            double result = Math.Pow(Largura, 2) + Math.Pow(Altura,2);
            return Math.Sqrt(result);
        }

        public override string ToString()
        {
            return "AREA = "+Area().ToString("f2",CultureInfo.InvariantCulture)
                +"\nPERIMETRO = "+Perimetro().ToString("f2", CultureInfo.InvariantCulture)
                +"\nDIAGONAL = "+Diagonal().ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
