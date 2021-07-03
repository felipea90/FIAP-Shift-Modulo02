using System;

namespace Exercicio01.Models
{
    public class ContaCorrente
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

        public decimal Saldo { get; private set; }
        public double Numero { get; set; }
        public bool Especial { get; set; }
        public decimal Limite { get; set; }
        public Cliente Cliente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public double Juros { get; set; }

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
            if ((Especial && valor <= Saldo + Limite) || (valor <= Saldo))
            {
                Saldo -= valor;
                return true;
            }

            //if (Especial)
            //{
            //    if (valor <= Saldo + Limite)
            //    {
            //        Saldo -= valor;
            //        return true;
            //    }
            //}
            //else
            //{
            //    if (valor <= Saldo)
            //    {
            //        Saldo -= valor;
            //        return true;
            //    }
            //}

            return false;
        }

        public decimal RetornarSaldoTotal()
        {
            //Ternário (Condição ? Se Verdadeiro : Se Falso)
            //return Especial ? Saldo + Limite : Saldo;

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

            return false;
        }

        public decimal CalcularValorTaxaJuros(int dias)
        {
            if (Saldo < 0)
                return dias * Convert.ToDecimal(Juros) * Saldo * -1;
            return 0;
        }
    }
}
