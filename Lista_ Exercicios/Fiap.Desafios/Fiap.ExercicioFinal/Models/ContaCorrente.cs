using Fiap.ExercicioFinal.ExceptionModel;
using System.Collections.Generic;

namespace Fiap.ExercicioFinal.Models
{
    public class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }
        public decimal Limite { get; set; }

        public ContaCorrente(
            int agencia,
            int numero,
            IList<Cliente> clientes,
            TipoConta tipo) : base(agencia, numero, clientes)
        {
            Tipo = tipo;
            DefinirLimite();
        }

        public void DefinirLimite()
        {
            Limite = Tipo == TipoConta.Especial ? Limite = 500 : Tipo == TipoConta.Premium ? Limite = 1000 : 0;
        }

        public override void Retirar(decimal valor)
        {
            if ((Tipo == TipoConta.Comum && valor > Saldo) || valor > Saldo + Limite)
            {
                throw new MessageException("Saldo Insuficiente");
            }

            Saldo -= valor;
        }
        public override string ToString()
        {
            return base.ToString() + $" \nTipo Conta: {Tipo} \nLimite: {Limite}";
        }
    }
}
