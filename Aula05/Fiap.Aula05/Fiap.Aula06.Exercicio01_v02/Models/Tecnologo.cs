namespace Fiap.Aula06.Exercicio01_02.Models
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

        protected override void DefinirDuracao()
        {
            Duracao = 24;
        }

        //Sobrescrever o método ToString() do Object
        public override string ToString()
        {
            return base.ToString() + $"Plano Estendido: {PlanoEstendido}";
        }
    }
}
