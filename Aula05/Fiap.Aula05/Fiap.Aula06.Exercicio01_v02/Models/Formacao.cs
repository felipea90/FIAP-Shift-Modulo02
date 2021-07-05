namespace Fiap.Aula06.Exercicio01_02.Models
{
    public class Formacao
    {
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public decimal Mensalidade { get; set; }
        public Instituicao Instituicao { get; set; }

        public Formacao(string nome)
        {
            Nome = nome;
            DefinirDuracao();
        }

        protected virtual void DefinirDuracao()
        {
            //Verificar o tipo do obejto usando GetType() --> Modo 01

            //if (GetType() == typeof(Tecnologo))
            //{
            //    Duracao = 24;
            //}
            //else if (GetType() == typeof(Bacharelado))
            //{
            //    if (Nome.ToLower().Contains("engenharia"))
            //    {
            //        Duracao = 60;
            //    }
            //    else
            //    {
            //        Duracao = 48;
            //    }
            //}
            //else
            //{
            //    Duracao = 48;
            //}

            //Modo 02 --> Usando Protected Virtual na classe pai

            Duracao = 48;

        }

        public float CalcularMedia(float nota1, float nota2)
        {
            return (nota1 + nota2) / 2;
        }

        public float CalcularMedia(float nota1, float nota2, float nota3)
        {
            return (nota1 > nota3 && nota2 > nota3) ? CalcularMedia(nota1, nota2) 
                   : (nota1 > nota2 && nota2 < nota3) ? CalcularMedia(nota1, nota3) 
                   : CalcularMedia(nota2, nota3);
        }

        public virtual decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 400;
        }
    }
}
