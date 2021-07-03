using Fiap.Aula04.Exemplo01.Models;
using System;

namespace Fiap.Aula04.Exemplo01
{
    class Exemplo01
    {
        static void Main(string[] args)
        {
            //Instanciar a classe Carro utilizando o CTOR com argumentos

            //CTOR com 1 argumento
            var cronos = new Carro("Cronos 1.8");

            //CTOR com 2 argumentos
            var fiesta = new Carro("Fiesta 1.6", 2015);

            //Exibir os valores dos objetos
            Console.WriteLine($"Modelo: {cronos.Modelo}, Ano: {cronos.Ano} ");
            Console.WriteLine($"Modelo: {fiesta.Modelo}, Ano: {fiesta.Ano} ");

            //Instanciar a moto com ctor padrão, informando os valores para as propriedades
            var biz = new Moto()
            {
                Cilindrada = 150,
                Passageiros = 2
            };

            //Exbibir os dados da Moto
            Console.WriteLine($"Cilindrada: {biz.Cilindrada}, Passageiros: {biz.Passageiros}");
        }
    }
}
