using System;

namespace Fiap.Aula03.Exercicio01.Models
{
    public class ContaPoupanca : Conta, IContaInvestimento
    {
        public ContaPoupanca(double numero)
        {
            Numero = numero;
        }

        public decimal Rendimentos { get; set; }

        public decimal CalcularRetornoInvestimento(decimal taxa)
        {
            return Saldo * taxa;
        }

        public bool Retirar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }

            throw new Exception("Saldo insuficiente");
        }
    }
}