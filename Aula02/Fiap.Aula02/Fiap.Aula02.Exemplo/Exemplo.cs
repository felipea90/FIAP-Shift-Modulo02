using Fiap.Aula02.Exemplo.Models;
using System;

namespace Fiap.Aula02.Exemplo
{
    class Exemplo
    {
        static void Main(string[] args)
        {
            //Instanciar a Classe
            Produto produto1 = new Produto();
            Produto produto2 = new Produto();

            Fabricante fabricante1 = new Fabricante();
            Fabricante fabricante2 = new Fabricante();

            //Atribuindo os valores
            produto1.Id = 10;
            produto1.Nome = "Vostro";
            produto1.Valor = 1500;

            produto2.Nome = "Fiesta";

            fabricante1.Nome = "Dell";
            fabricante1.Ativo = false;
            fabricante1.Cnpj = "12345678901999";

            fabricante2.Nome = "Ford";

            //Atribuir o objeto Fabricante no atributo do objeto Produto
            produto1.Fabricante = fabricante1;

            produto2.Fabricante = fabricante2;

            //Recuperando os valores
            Console.WriteLine($"O Identificador do Produto {produto1.Nome} é {produto1.Id}");

            //Exibir o nome do Fabricante e se está ativo
            if (fabricante1.Ativo)
            {
                Console.WriteLine($"O Fabricante {fabricante1.Nome} está Ativo!");
            }
            else
            {
                Console.WriteLine($"O Fabricante {produto1.Fabricante.Nome} está Inativo!");
            }

            Console.WriteLine($"Produto 2 {produto2.Nome}");
            Console.WriteLine($"Fabricante 2 {produto2.Fabricante.Nome}");

        }
    }
}
