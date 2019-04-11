using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos
{
    class ConversorDeMoeda
    {
        public static double IOF = 0.06;
        public static double CotacaoDolar { get; set; }

        public static double ValorPagoReais(double valor)
        {
            return CotacaoDolar * valor * (1+IOF);
        }
    }
}
