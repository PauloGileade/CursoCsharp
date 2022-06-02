using System;

namespace Aula09TiposReferenciaETiposValor
{
    internal struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
