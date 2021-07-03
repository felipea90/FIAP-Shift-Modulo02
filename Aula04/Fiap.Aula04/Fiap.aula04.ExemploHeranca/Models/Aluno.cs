namespace Fiap.aula04.ExemploHeranca.Models
{
    //A classe Aluno herda de Pessoa (possuirá os atributos e métodos da Pessoa)
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade, int matricula, string curso) : base(nome, idade)
        {
            Matricula = matricula;
            Curso = curso;
        }

        public Aluno(string nome, int matricula) : base(nome)
        {
            Matricula = matricula;
        }

        //Propriedades
        public int Matricula { get; set; }
        public string Curso { get; set; }

        //Métodos
        public void ObterPresenca()
        {
            System.Console.WriteLine($"Aluno {Nome} presente");
        }
    }
}
