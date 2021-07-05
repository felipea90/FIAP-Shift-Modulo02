using Fiap.Aula06.Exercicio01.Models;
using System;

namespace Fiap.Aula06.Exercicio01
{
    class Exercicio01
    {
        static void Main(string[] args)
        {
            var tecnologo = new Tecnologo("Desenvolvimento")
            {
                PlanoEstendido = false,
                Tecnologo = true,
                Bacharelado = false
            };

            var engenharia = new Bacharelado("engenharia", 200)
            { 
                ProjetoConclusao = "Construir um carro",
                Tecnologo = false,
                Bacharelado = true
            };

            var biologia = new Bacharelado("biologia", 150)
            {
                ProjetoConclusao = "Pesquisar planta",
                Tecnologo = false,
                Bacharelado = true
            };

            var secretariado = new Formacao("secretariado")
            {
                Tecnologo = false,
                Bacharelado = false
            };

            Console.WriteLine("TECNOLOGO");
            Console.WriteLine(tecnologo.CalcularMensalidade());
            Console.WriteLine(tecnologo.CalcularMedia(9, 6));
            Console.WriteLine(tecnologo.CalcularMedia(8, 7, 2));

            Console.WriteLine();

            Console.WriteLine("BACHARELADO ENG");
            Console.WriteLine(engenharia.CalcularMensalidade());
            Console.WriteLine(engenharia.CalcularMedia(9, 6));
            Console.WriteLine(engenharia.CalcularMedia(9, 7, 3));

            Console.WriteLine();

            Console.WriteLine("BACHARELADO");
            Console.WriteLine(biologia.CalcularMensalidade());
            Console.WriteLine(biologia.CalcularMedia(5, 8));
            Console.WriteLine(biologia.CalcularMedia(8, 5, 6));

            Console.WriteLine();

            Console.WriteLine("COMUM");
            Console.WriteLine(secretariado.CalcularMensalidade());
            Console.WriteLine(secretariado.CalcularMedia(6, 9));
            Console.WriteLine(secretariado.CalcularMedia(10, 3, 5));
        }
    }
}
