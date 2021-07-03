using Fiap.aula04.ExemploHeranca.Models;
using System;

namespace Fiap.aula04.ExemploHeranca
{
    class ExHeranca
    {
        static void Main(string[] args)
        {
            //Instanciar uma Pessoa
            var pessoa1 = new Pessoa("Fulano");

            //Atribuir os valores da Pessoa
            //pessoa1.Nome = "Fulano";

            var pessoa2 = new Pessoa("Ciclano", 25);

            //Instanciar um Aluno
            var aluno1 = new Aluno("Felipe", 31, 388644, "C#");

            //Atribuir os valores do Aluno
            //aluno1.Nome = "Felipe";
            //aluno1.Idade = 31;
            //aluno1.Matricula = 388644;
            //aluno1.Curso = "C#";

            var aluno2 = new Aluno("Tassia", 3523);

            //Chamar o método RetornarDados e exibir os dados
            Console.WriteLine(aluno1.RetornarDados());
            Console.WriteLine(pessoa1.RetornarDados());
            Console.WriteLine(aluno2.RetornarDados());
            Console.WriteLine(pessoa2.RetornarDados());

            //Método exclusivo da classe aluno
            aluno1.ObterPresenca();
            aluno2.ObterPresenca();
        }
    }
}
