using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos
{
    class Aluno
    {
        public string Nome { get; set; }
        public double Nota { get; set; }
        public double Corte { get; set; }

        public void AdicionaNota(double nota)
        {
            Nota += nota;
        }

        public string Classificado()
        {
            if (Nota >= Corte)
            {
                return "Aprovado";
            }
            else
            {
                return $"Reprovado \nFaltaram {Corte-Nota:F2} Pontos";
            }
        }

        public override string ToString()
        {
            return $"Nota Final: {Nota:F2} {Classificado()}";
        }
    }
}
