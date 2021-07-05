namespace Fiap.Aula06.Exercicio01_02.Models
{
    public class Bacharelado : Formacao
    {
        public string ProjetoConclusao { get; set; }
        public int CargaHorarioEstagio { get; set; }

        public Bacharelado(string nome, int carga) : base(nome)
        {
            CargaHorarioEstagio = carga;
        }

        public override decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 600 + CargaHorarioEstagio * 12;
        }

        public decimal CalcularMensalidade(decimal desconto)
        {
            return CalcularMensalidade() - (Mensalidade * desconto)/100;
        }

        protected override void DefinirDuracao()
        {

            if (Nome.ToLower().Contains("engenharia"))
            {
                Duracao = 60;
            }
            else
            {
                Duracao = 48;
            }

        }
    }
}
