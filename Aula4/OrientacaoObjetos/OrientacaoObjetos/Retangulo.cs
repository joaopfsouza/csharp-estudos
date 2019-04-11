using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos
{
    class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * Largura + 2 * Altura;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }


        public override string ToString()
        {
            return $"Area:{Area():F2} Perimetro:{Perimetro():F2} Diagonal: {Diagonal():F2}";
        }
    }
}
