using System;

namespace Fiap.Aula03.Exercicio01.Models
{
    public class Conta
    {
        public decimal Saldo { get; protected set; }
        public double Numero { get; set; }

        public bool Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }

            throw new Exception("Saldo Insuficiente");
        }
    }
}
