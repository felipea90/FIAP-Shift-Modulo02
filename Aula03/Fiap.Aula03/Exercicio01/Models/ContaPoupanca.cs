using System;

namespace Exercicio01.Models
{
    public class ContaPoupanca
    {
        public decimal Saldo { get; private set; }
        public double Numero { get; set; }
        public decimal Rendimentos { get; set; }

        public bool Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }

            return false;
        }

        public bool Retirar(decimal valor)
        {
            if (valor <= Saldo)
            {
               Saldo -= valor;
                return true;
            }
            
            return false;
        }
    }
}
