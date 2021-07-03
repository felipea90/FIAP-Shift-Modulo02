namespace Fiap.aula04.ExemploHeranca.Models
{
    //protected internal -> classes filhas e do mesmo projeto
    //protected private -> classes filhas dentro do mesmo projeto
    public class Pessoa
    {
        //Construtor de Pessoa com Nome
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        //Propriedades
        public string Nome { get; set; }
        public int Idade { get; set; }

        //Métodos
        public string RetornarDados()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }

    }
}
