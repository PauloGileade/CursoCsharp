using System;


namespace Projeto07 {
    class ConversorDeMoeda {

        public static double Iof = 6.0;

        public static double DolarParaReal(double cotacao, double comprar) {

            double total = cotacao * comprar;

            return total + total * Iof / 100;
        }
    }
}

