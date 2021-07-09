using System;

namespace Fiap.Aula03.Exercicio01.Models
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(
            double numero,
            Cliente cliente,
            ContaPoupanca contaPoupanca,
            bool especial)
        {
            Numero = numero;
            Cliente = cliente;
            ContaPoupanca = contaPoupanca;
            Especial = especial;
        }

        public bool Especial { get; set; }
        public decimal Limite { get; set; }
        public Cliente Cliente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public double Juros { get; set; }

        public bool Retirar(decimal valor)
        {
            if ((Especial && valor <= Saldo + Limite) || (valor <= Saldo))
            {
                Saldo -= valor;
                return true;
            }

            throw new Exception("Saldo Insuficiente");
        }

        public decimal RetornarSaldoTotal()
        {

            if (Especial)
            {
                return Saldo + Limite;
            }
            else
            {
                return Saldo;
            }
        }

        public bool TransferirParaPoupanca(decimal valor)
        {
            if (Retirar(valor))
            {
                ContaPoupanca.Depositar(valor);
                return true;
            }

            throw new Exception("Saldo Insuficiente");
        }

        public decimal CalcularValorTaxaJuros(int dias)
        {
            if (Saldo < 0)
                return dias * Convert.ToDecimal(Juros) * Saldo * -1;
            return 0;
        }
    }
}