using Fiap.Aula05.Exercicio01.Models;
using System;

namespace Fiap.Aula05.Exercicio01
{
    class Exercicio01
    {
        static void Main(string[] args)
        {
            var produto = new Produto(1, "Camiseta")
            {
                Preco = 35
            };

            var eletronico = new Eletronico(2, "Notebook")
            {
                Garantia = true,
                Preco = 4200
            };

            var livro = new Livro(3, "Jardim Bucetinha", "Linguiça", 35, 2020)
            {
                Preco = 45
            };

            var arroz = new Perecivel(4, "Camil", new DateTime(25 / 12 / 2021))
            {
                Preco = 12
            };

            Console.WriteLine("Produto");
            Console.WriteLine($"O preço original é R$ {produto.Preco}");
            Console.WriteLine($"O preço com desconto é R$ {produto.CalcularDesconto(15)}");

            Console.WriteLine("Eletrônico");
            Console.WriteLine($"O preço original é R$ {eletronico.Preco}");
            Console.WriteLine($"O preço com desconto é R$ {eletronico.CalcularDesconto(10)}");
            Console.WriteLine($"O valor da garantia estendida é R$ {eletronico.CalcularGarantiaEstendida()}");

            Console.WriteLine("Livro");
            Console.WriteLine($"O preço original é R$ {livro.Preco}");
            Console.WriteLine($"O preço com desconto é R$ {livro.CalcularDesconto(7)}");

            Console.WriteLine("Perecível");
            Console.WriteLine($"O preço original é R$ {arroz.Preco}");
            Console.WriteLine($"O preço com desconto é R$ {arroz.CalcularDesconto(5)}");

        }
    }
}
