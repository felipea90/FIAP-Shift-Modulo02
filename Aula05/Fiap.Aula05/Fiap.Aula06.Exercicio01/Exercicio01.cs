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

            Console.WriteLine("CURSO TECNOLOGO");
            Console.WriteLine($"Mensalidade R$ {tecnologo.CalcularMensalidade()}");
            Console.WriteLine($"Média de duas notas {tecnologo.CalcularMedia(9, 6)}");
            Console.WriteLine($"Média de três notas {tecnologo.CalcularMedia(8, 7, 2)}");

            Console.WriteLine();

            Console.WriteLine("CURSO BACHARELADO ENG");
            Console.WriteLine($"Mensalidade R$ {engenharia.CalcularMensalidade()}");
            Console.WriteLine($"Média de duas notas {engenharia.CalcularMedia(9, 6)}");
            Console.WriteLine($"Média de três notas {engenharia.CalcularMedia(9, 7, 3)}");

            Console.WriteLine();

            Console.WriteLine("CURSO BACHARELADO");
            Console.WriteLine($"Mensalidade R$ {biologia.CalcularMensalidade()}");
            Console.WriteLine($"Média de duas notas {biologia.CalcularMedia(5, 8)}");
            Console.WriteLine($"Média de três notas {biologia.CalcularMedia(8, 5, 6)}");

            Console.WriteLine();

            Console.WriteLine("CURSO COMUM");
            Console.WriteLine($"Mensalidade R$ {secretariado.CalcularMensalidade()}");
            Console.WriteLine($"Média de duas notas {secretariado.CalcularMedia(6, 9)}");
            Console.WriteLine($"Média de três notas {secretariado.CalcularMedia(10, 3, 5)}");
        }
    }
}
