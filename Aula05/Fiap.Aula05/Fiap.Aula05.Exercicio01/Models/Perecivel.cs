using System;

namespace Fiap.Aula05.Exercicio01.Models
{
    public class Perecivel : Produto
    {
        public DateTime DataValidade { get; set; }

        public Perecivel(
            int id, 
            string nome, 
            DateTime dataValidade) : base(id, nome)
        {
            DataValidade = dataValidade;
        }
    }
}
