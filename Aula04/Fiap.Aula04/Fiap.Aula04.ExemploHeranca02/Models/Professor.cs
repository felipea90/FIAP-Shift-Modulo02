using Fiap.aula04.ExemploHeranca.Models;

namespace Fiap.Aula04.ExemploHeranca02.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome, int funcional, string materia) : base(nome)
        {
            Funcional = funcional;
            MateriaLecionada = materia;
        }

        public Professor(string nome, int idade, int funcional) : base(nome, idade)
        {
            Funcional = funcional;
        }

        //Propriedades
        public int Funcional { get; set; }
        public string MateriaLecionada { get; set; }

        //Métodos
        public void FazerChamada()
        {
            System.Console.WriteLine($"{Nome} está fazendo a chamada...");
        }
    }
}
