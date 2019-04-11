using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto *= (1 + porcentagem / 100);
        }

        public override string ToString()
        {
            return $"{Nome} {SalarioLiquido():C}";
        }
    }
}
