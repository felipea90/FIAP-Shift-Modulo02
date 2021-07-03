using Fiap.aula04.ExemploHeranca.Models;
using Fiap.Aula04.ExemploHeranca02.Models;
using System;

namespace Fiap.Aula04.ExemploHeranca02
{
    class ExHeranca2
    {
        static void Main(string[] args)
        {
            //Instanciar um Professor
            var professor = new Professor("Felipe", 351245, "Matemática");

            //professor.Nome = "Felipe";
            //professor.Idade = 31;
            //professor.Funcional = 351245;
            //professor.MateriaLecionada = "Matemática";

            professor.FazerChamada();
            Console.WriteLine(professor.RetornarDados());

            var professor2 = new Professor("Bruno", 32, 369);

            professor2.FazerChamada();
            Console.WriteLine(professor2.RetornarDados());

            //Instanciar um Aluno chamando referência em outro projeto
            var aluno = new Aluno("Tairine", 188);

            //aluno.Nome = "Tairine";
            //aluno.Idade = 30;
            //aluno.Matricula = 188;
            //aluno.Curso = "Secretatiado";

            aluno.ObterPresenca();
            Console.WriteLine(aluno.RetornarDados());

            var aluno2 = new Aluno("Henrique", 18, 2221, "Pediatria");

            aluno2.ObterPresenca();
            Console.WriteLine(aluno2.RetornarDados());

        }
    }
}
