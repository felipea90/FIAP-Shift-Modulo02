namespace Fiap.Aula06.Exercicio01.Models
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
    }
}
