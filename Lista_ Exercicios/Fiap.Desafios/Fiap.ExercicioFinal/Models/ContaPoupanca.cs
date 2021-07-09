using Fiap.ExercicioFinal.ExceptionModel;
using System.Collections.Generic;

namespace Fiap.ExercicioFinal.Models
{
    public class ContaPoupanca : Conta, IContaInvestimento
    {
        public decimal Taxa { get; set; }

        public ContaPoupanca(
            int agencia,
            int numero,
            IList<Cliente> clientes,
            decimal taxa) : base(agencia, numero, clientes)
        {
            Taxa = taxa;
        }

        public override void Retirar(decimal valor)
        {
            if (valor + Taxa > Saldo)
                throw new MessageException("Saldo Insuficiente");
            Saldo -= valor + Taxa;
        }

        public decimal CalcularRetornoInvestimento()
        {
            return Saldo * 0.04m;
        }
        public override string ToString()
        {
            return base.ToString() + $" \nTaxa: {Taxa}";
        }
    }
}
