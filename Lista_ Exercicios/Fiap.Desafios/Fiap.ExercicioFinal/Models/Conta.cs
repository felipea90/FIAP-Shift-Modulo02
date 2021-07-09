using System;
using System.Collections.Generic;

namespace Fiap.ExercicioFinal.Models
{
    public abstract class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; protected set; }
        public DateTime DataAbertura { get; set; }
        public IList<Cliente> Clientes { get; set; }

        public Conta(
            int agencia,
            int numero,
            IList<Cliente> clientes)
        {
            Agencia = agencia;
            Numero = numero;
            Clientes = clientes;
        }

        public virtual void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public virtual void Retirar(decimal valor)
        {
        }

        public override string ToString()
        {
            var detalhes = "";

            foreach (var item in Clientes)
            {
                detalhes += $"{item} \n";
            }

            detalhes += $"Agência: {Agencia} \nNúmero: {Numero} \nSaldo: {Saldo} \nData de Abertura: {DataAbertura}";

            return detalhes;
        }
    }
}
