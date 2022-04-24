using System;
using System.Globalization;

namespace Projeto04 {
    class Program {
        static void Main(string[] args) {

            Retangulo r = new Retangulo();

            Console.Write("Digite a Largura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a Altura do retângulo: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("AREA = " + r.Area().ToString("f2", CultureInfo.InvariantCulture));
            Console.Write("\nPERÍMETRO = " + r.Perimetro().ToString("f2", CultureInfo.InvariantCulture));
            Console.Write("\nDIAGONAL = " + r.Diagonal().ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
