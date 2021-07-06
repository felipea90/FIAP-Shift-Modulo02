using Fiap.Aula07.Exemplo01.Models;
using System;

namespace Fiap.Aula07.Exemplo01
{
    class Exemplo01
    {
        static void Main(string[] args)
        {
            //Não consegue instanciar classe Pessoa
            //var pessoa = new Pessoa();

            //Instanciar uma pessoa Fisica
            var pf = new PessoaFisica()
            {
                Nome = "Felipe",
                Genero = Genero.Masculino
            };

            //Validar o sexo
            if (pf.Genero == Genero.Masculino)
                Console.WriteLine("Tu é brabo");
            else
                Console.WriteLine("tu é froxo");

            //Exibir o valor
            Console.WriteLine(pf.Genero);
            Console.WriteLine((int)pf.Genero); //Exibe o valor da constante
        }
    }
}
