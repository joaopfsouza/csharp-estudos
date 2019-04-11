using System;
using System.Collections.Generic;
using System.Text;

namespace Conta
{
    class Conta
    {
        private static double taxa = 5.00;
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(int numeroConta, string titular)
        {
            Numero = numeroConta;
            Titular = titular;
        }
        public Conta(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + taxa;
        }

        public override string ToString()
        {
            return $"{Numero} {Titular} {Saldo:C} ";
        }
    }
}
