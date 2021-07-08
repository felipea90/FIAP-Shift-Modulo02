namespace Fiap.Aula08.Exercicio01.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public float Nota { get; set; }
        public Genero Genero { get; set; }

        public Aluno(
            string nome,
            float nota,
            Genero genero)
        {
            Nome = nome;
            Nota = nota;
            Genero = genero;
        }
    }
}
