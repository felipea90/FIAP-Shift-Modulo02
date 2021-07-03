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
                PlanoEstendido = false
            };

            var engenharia = new Bacharelado("enganheira mecanica", 200)
            { 
                ProjetoConclusao = "Construir um carro"
            };

            var biologia = new Formacao("biologia")
            {

            };

            Console.WriteLine(tecnologo.CalcularMensalidade());
            Console.WriteLine(tecnologo.CalcularMedia(9, 6));
            Console.WriteLine(tecnologo.CalcularMedia(8, 7, 2));

            Console.WriteLine(engenharia.CalcularMensalidade());
            Console.WriteLine(engenharia.CalcularMedia(9, 6));
            Console.WriteLine(engenharia.CalcularMedia(9, 7, 3));

            Console.WriteLine(biologia.CalcularMensalidade());
            Console.WriteLine(biologia.CalcularMedia(5, 8));
            Console.WriteLine(biologia.CalcularMedia(8, 5, 6));
        }
    }
}
