namespace Fiap.Aula06.Exercicio01.Models
{
    public class Tecnologo : Formacao
    {
        public bool PlanoEstendido { get; set; }

        public Tecnologo(string nome) : base(nome)
        {
        }

        public override decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 500;
        }
    }
}
